using System;

namespace RectangleProgram {
    class Rectangle{
        double height;
        double width;

        public void setValues(){
            height = 4.5;
            width = 3.5;
        }


        public void getArea(){
            Console.WriteLine("Area of the rectangle: {0}", (width * height));
        }

        public void display(){
            Console.WriteLine("Height: {0}", height);
            Console.WriteLine("Width: {0}", width);
        }
    }

    class DisplayRectangle{
        static void Main(string[] args){
            Rectangle rectangle = new Rectangle();
            rectangle.setValues();
            rectangle.display();
            rectangle.getArea();
        }
    }
}