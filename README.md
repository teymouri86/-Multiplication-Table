Multiplication Table Generator (C# WinForms)

A clean and simple Windows Forms application that generates and displays a 10×10 Multiplication Table using a "DataGridView".
This project is perfect for beginners learning WinForms or C# UI programming.

---

📌 Overview

This project demonstrates:

- Automatic generation of a 10×10 multiplication table
- Dynamically created column & row headers (1–10)
- Center-aligned numeric values
- Clean and compact WinForms implementation
- Easy drop-in code for any C# project

---

⭐ Features

- ✔️ Fully dynamic table generation
- ✔️ No external libraries required
- ✔️ Clean UI with centered cells and headers
- ✔️ Beginner-friendly and well-structured
- ✔️ Works on .NET Framework and .NET 6+

---

📂 Code Snippet

Paste this code inside your form (e.g., "Form1_Load").
Make sure you have a "DataGridView" named dataGridView1 on the form.

private void Form1_Load(object sender, EventArgs e)
{
    dataGridView1.Columns.Clear();

    // Create columns (1 to 10)
    for (int c = 1; c <= 10; c++)
    {
        var col = new DataGridViewTextBoxColumn();
        col.HeaderText = c.ToString();
        col.Width = 50;
        dataGridView1.Columns.Add(col);
    }

    // Create rows
    for (int r = 1; r <= 10; r++)
    {
        object[] cells = new object[10];
        for (int c = 1; c <= 10; c++)
        {
            cells[c - 1] = r * c;
        }

        int index = dataGridView1.Rows.Add(cells);
        dataGridView1.Rows[index].HeaderCell.Value = r.ToString();
    }

    // Styling (optional)
    dataGridView1.RowHeadersWidth = 60;
    dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
}

---

🛠 Requirements

- Windows OS
- .NET Framework or .NET 6+
- Visual Studio (recommended)
- WinForms project
- A "DataGridView" named dataGridView1

---

📸 Preview (Sample Layout)

     1   2   3   4   5   6   7   8   9   10
1    1   2   3   4   5   6   7   8   9   10
2    2   4   6   8  10  12  14  16  18   20
3    ...
.
10   ...

---

🚀 How to Use

1. Create a Windows Forms App project
2. Add a DataGridView to the form
3. Set its name → "dataGridView1"
4. Copy the code into your form
5. Run the project

That’s it — your multiplication table will appear automatically!

---

📜 License

This project is released under the MIT License.
Free for personal, educational, and commercial use.

---

🤝 Contributions

Pull requests and improvements are welcome!
If you want extra features (dynamic size, colors, themes, export to PDF/Excel), feel free to open an issue.

---

⭐ If You Like It

Give the repository a star ⭐ to support the project!
