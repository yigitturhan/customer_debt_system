using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace CustomerDebtSystem
{
    public class PrintingManager
    {
        public static void PrintDataGridView(DataGridView dataGridView)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (sender, e) =>
            {
                Graphics graphics = e.Graphics;
                int cellHeight = 25;
                int x = 10;
                int y = e.MarginBounds.Top;
                for (int i = 2; i < dataGridView.Columns.Count; i++)
                {
                    graphics.DrawString(dataGridView.Columns[i].HeaderText, new Font("Arial", 12, FontStyle.Bold),Brushes.Black, x, y);
                    x += dataGridView.Columns[i].Width;
                }
                y += cellHeight;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    x = 10;
                    for (int i = 2; i < dataGridView.Columns.Count; i++)
                    {
                        graphics.DrawString(row.Cells[i].Value.ToString(), new Font("Arial", 12),Brushes.Black, x, y);
                        x += dataGridView.Columns[i].Width;
                    }
                    y += cellHeight;
                }
            };
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK) printDocument.Print();
        }
    }
}