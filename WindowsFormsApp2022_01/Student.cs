using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2022_01
{

    public class Student : UpdateListener
    {

        private Form1 form;
        private StudentView view;

        private String id;
        private String name;

        public Student(Form1 form, StudentView view, String id, String name)
        {

            this.form = form;
            this.view = view;

            setId(id);
            setName(name);

            form.addListener(this);

            show();

        }

        public void show()
        {

            view.Show();

        }
        public void hide()
        {

            view.Hide();

        }

        public String getId()
        {

            return id;

        }

        public String setId(String id)
        {

            this.id = id;

            view.getId().Text = id;

            return id;

        }

        public String getName()
        {

            return name;

        }

        public String setName(String name)
        {

            this.name = name;

            view.getName().Text = name;

            return name;

        }

        public void update()
        {

            view.getName().Text = form.getLabelText();

//            view.Show();

        }

    }

}
