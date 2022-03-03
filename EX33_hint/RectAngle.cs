using System;
using System.Collections.Generic;
using System.Text;

namespace EX33_hint
{
    //先生の見ながらやりました
    class RectAngle : ISurface, ICircumference, IBounds
    {
        readonly public float width;
        readonly public float height;
        public RectAngle(float width = 0, float height = 0)
        {
            this.width = width;
            this.height = height;
        }
        public float GetSurface()
        {
            return width * height;
        }
        public float GetCircumference()
        {
            return (width + height) * 2;
        }
        public void GetBounds(out float width, out float height)
        {
            width = this.width;
            height = this.height;
        }
        public static bool operator ==(RectAngle rectAngle1, RectAngle rectAngle2)
        {
            return rectAngle1.width == rectAngle2.width
                && rectAngle1.height == rectAngle2.height
                || rectAngle1.width == rectAngle2.height
                && rectAngle1.height == rectAngle2.width;
        }

        public static bool operator !=(RectAngle rectAngle1, RectAngle rectAngle2)
        {
            return rectAngle1.width == rectAngle2.width
                && rectAngle1.height == rectAngle2.height
                || rectAngle1.width == rectAngle2.height
                && rectAngle1.height == rectAngle2.width;
        }

        public static RectAngle operator +(RectAngle rectAngle1, RectAngle rectAngle2)
        {
            RectAngle rectAngleVirtical;
            RectAngle rectAngleHorizontal;
            if (rectAngle1.width>rectAngle2.width)
            {
                rectAngleVirtical = new RectAngle(rectAngle1.width,rectAngle1.height+rectAngle2.height);
            }
            else
            {
                rectAngleVirtical = new RectAngle(rectAngle2.width, rectAngle1.height + rectAngle2.height);
            }
            if (rectAngle1.height>rectAngle2.height)
            {
                rectAngleHorizontal = new RectAngle(rectAngle1.height, rectAngle1.width + rectAngle2.width);
            }
            else
            {
                rectAngleHorizontal = new RectAngle(rectAngle2.height, rectAngle1.width + rectAngle2.width);
            }
            RectAngle result;
            if (rectAngleVirtical.GetSurface()<rectAngleHorizontal.GetSurface())
            {
                result = rectAngleVirtical;
            }
            else
            {
                result = rectAngleHorizontal;
            }
            return result;
        }
        
    }
}
