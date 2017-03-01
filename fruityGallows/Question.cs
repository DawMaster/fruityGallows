using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace fruityGallows
{
    class Question
    {
        private String name;
        private Image img;
        public Question(String name, String img) {
            this.name = name;
            this.img = (Image)Properties.Resources.ResourceManager.GetObject(img);
        }
        public Image getImage() {
            return img;
        }
        public String getName() {
            return name;
        }
    }

}
