using L4_t_p;
using System.Drawing.Imaging;
using System.Xml.Linq;

namespace L4_t_p
{






    public partial class Form1 : Form
    {
        Graphics tree;
        BTree a;
        Pen pen;
        int scale = 40;
        int delitel = 2;
        BufferedGraphics buffered;
        BufferedGraphicsContext currentContext;
        public Form1()
        {
            InitializeComponent();
            tree = CreateGraphics();
            currentContext = BufferedGraphicsManager.Current;
            buffered = currentContext.Allocate(this.CreateGraphics(), this.DisplayRectangle);
        }
        

        public void DrawnewTree(Point precoord, BNode bTree, int range)
        {

            pen = new Pen(Color.Black, 3);
            buffered.Graphics.DrawEllipse(pen, precoord.X, precoord.Y, 30, 30);
            bTree.coords = precoord;
            buffered.Graphics.DrawString(bTree.Value.ToString(), new Font(DefaultFont, FontStyle.Bold), new SolidBrush(Color.Black), precoord.X + 5, precoord.Y + 5);
            precoord.X += range / delitel;
            precoord.Y += 1 * scale;
            if (bTree.right != null)
            {

                buffered.Graphics.DrawLine(pen, precoord.X - range / delitel + 15, precoord.Y - 1 * scale + 30, precoord.X + 15, precoord.Y);
                DrawnewTree(precoord, bTree.right, range / delitel);
            }
            precoord.X -= range / (delitel / 2);
            if (bTree.left != null)
            {
                buffered.Graphics.DrawLine(pen, precoord.X + range / delitel + 15, precoord.Y - 1 * scale + 30, precoord.X + 15, precoord.Y);
                DrawnewTree(precoord, bTree.left, range / delitel);
            }
        }



        private void Form1_Shown(object sender, EventArgs e)
        {
            a = new BTree();

            buffered.Graphics.Clear(this.BackColor);
            DrawnewTree(new Point(Width / 2 - 50, 100), a.tree, Width / 2 - 200);
            //buffered.Render();
            buffered.Render(tree);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (a.tree != null)
            {

                var result = a.tree.Find((int)SearchNUD.Value);


                tree.Clear(this.BackColor);
                buffered.Graphics.Clear(this.BackColor);
                DrawnewTree(new Point(Width / 2 - 50, 100), a.tree, Width / 2 - 200);
                buffered.Render(tree);


                pen = new Pen(Color.Green, 3);
                if (result != null)
                {
                    InfoLBL.Text = "найдено успешно";
                    tree.DrawEllipse(pen, result.coords.X - 5, result.coords.Y - 5, 40, 40);
                }
                else {
                    InfoLBL.Text = "не получилось найти";
                }
            }
        }

        private void CreateTreeBTN_Click(object sender, EventArgs e)
        {
            // BNode b = a.rightRotate(a.tree);
            a = new BTree();
            tree.Clear(this.BackColor);
            buffered.Graphics.Clear(this.BackColor);
            DrawnewTree(new Point(Width / 2 - 50, 100), a.tree, Width / 2 - 200);
            //buffered.Render();
            buffered.Render(tree);
        }

        private void DelBTN_Click(object sender, EventArgs e)
        {
            if (a.Del((int)SearchNUD.Value)) {
                InfoLBL.Text = "Удалено успешно";
            }
            else
            {
                InfoLBL.Text = "Удаление не получилось";

            }
            if (a.tree != null)
            {

                tree.Clear(this.BackColor);
                buffered.Graphics.Clear(this.BackColor);
                DrawnewTree(new Point(Width / 2 - 50, 100), a.tree, Width / 2 - 200);
                buffered.Render(tree);
            }
            else
            {
                tree.Clear(this.BackColor);
                //buffered.Render(tree);
            }
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            if (a.AddValue((int)SearchNUD.Value))
            {
                InfoLBL.Text = "добавлено успешно";
            }
            else
            {
                InfoLBL.Text = "не получилось добавить";
            }
            tree.Clear(this.BackColor);
            buffered.Graphics.Clear(this.BackColor);
            DrawnewTree(new Point(Width / 2 - 50, 100), a.tree, Width / 2 - 200);
            buffered.Render(tree);
        }
    }
}
