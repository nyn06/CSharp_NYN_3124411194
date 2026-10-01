using System;
using System.Collections;

namespace TH02
{
    public class ArrayPoint
    {
        // khai bao ArrayList luu cac Point
        private ArrayList dsPoint;

        // constructor mac dinh
        public ArrayPoint()
        {
            dsPoint = new ArrayList();
        }

        // them Point vao danh sach
        public void Add(Point p)
        {
            dsPoint.Add(p);
        }

        // indexer truy cap Point thu i
        public Point this[int i]
        {
            get
            {
                return (Point)dsPoint[i];
            }

            set
            {
                dsPoint[i] = value;
            }
        }
    }
}