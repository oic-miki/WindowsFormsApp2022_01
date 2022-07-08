using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2022_01
{

    class Student
    {

        private StudentView view;

        private String id;
        private String name;

        public Student(StudentView view, String id, String name)
        {

            this.view = view;

            setId(id);
            setName(name);

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

    }

}
