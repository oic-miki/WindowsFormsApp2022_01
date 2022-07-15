using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2022_01
{
    public partial class Form1 : Form
    {
        private List<UpdateListener> listeners = new List<UpdateListener>();

        public Form1()
        {
            InitializeComponent();
        }

        public void addListener(UpdateListener listener)
        {

            listeners.Add(listener);

            label1.Text = "変ったよ！";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            init();

            for (int count = 1; count < 10; count++)
            {

                /*
                students.Add(new Student(
                    this,
                    new StudentView(),
                    "C000" + count,
                    "三木"));
                */
                new Student(
                    this,
                    new StudentView(),
                    "C000" + count,
                    "三木" + count);

            }

        }

        private void init()
        {

            foreach (Student student in listeners)
            {

                student.hide();

            }

            listeners.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            foreach (UpdateListener listener in listeners)
            {

//                student.show();
                listener.update();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            foreach (Student student in listeners)
            {

                student.setName("変ったよ！");

            }

        }

    }

}
