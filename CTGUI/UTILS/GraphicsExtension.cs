namespace Plasmoid.Extensions
{
    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    internal static class GraphicsExtension
    {
        public static void DrawRoundedRectangle(this Graphics graphics, Pen pen, Rectangle rectangle, int radius)
        {
            graphics.DrawRoundedRectangle(pen, (float)rectangle.X, (float)rectangle.Y, (float)rectangle.Width, (float)rectangle.Height, (float)radius, RectangleEdgeFilter.All);
        }

        public static void DrawRoundedRectangle(this Graphics graphics, Pen pen, RectangleF rectangle, int radius)
        {
            graphics.DrawRoundedRectangle(pen, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height, (float)radius, RectangleEdgeFilter.All);
        }

        public static void DrawRoundedRectangle(this Graphics graphics, Pen pen, Rectangle rectangle, int radius, RectangleEdgeFilter filter)
        {
            graphics.DrawRoundedRectangle(pen, (float)rectangle.X, (float)rectangle.Y, (float)rectangle.Width, (float)rectangle.Height, (float)radius, filter);
        }

        public static void DrawRoundedRectangle(this Graphics graphics, Pen pen, RectangleF rectangle, int radius, RectangleEdgeFilter filter)
        {
            graphics.DrawRoundedRectangle(pen, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height, (float)radius, filter);
        }

        public static void DrawRoundedRectangle(this Graphics graphics, Pen pen, int x, int y, int width, int height, int radius)
        {
            graphics.DrawRoundedRectangle(pen, Convert.ToSingle(x), Convert.ToSingle(y), Convert.ToSingle(width), Convert.ToSingle(height), Convert.ToSingle(radius));
        }

        public static void DrawRoundedRectangle(this Graphics graphics, Pen pen, float x, float y, float width, float height, float radius)
        {
            graphics.DrawRoundedRectangle(pen, x, y, width, height, radius, RectangleEdgeFilter.All);
        }

        public static void DrawRoundedRectangle(this Graphics graphics, Pen pen, float x, float y, float width, float height, float radius, RectangleEdgeFilter filter)
        {
            RectangleF rectangle = new RectangleF(x, y, width, height);
            GraphicsPath path = graphics.GenerateRoundedRectangle(rectangle, radius, filter);
            SmoothingMode smoothingMode = graphics.SmoothingMode;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.DrawPath(pen, path);
            graphics.SmoothingMode = smoothingMode;
        }

        public static void FillRoundedRectangle(this Graphics graphics, Brush brush, Rectangle rectangle, int radius)
        {
            graphics.FillRoundedRectangle(brush, (float)rectangle.X, (float)rectangle.Y, (float)rectangle.Width, (float)rectangle.Height, (float)radius, RectangleEdgeFilter.All);
        }

        public static void FillRoundedRectangle(this Graphics graphics, Brush brush, RectangleF rectangle, int radius)
        {
            graphics.FillRoundedRectangle(brush, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height, (float)radius, RectangleEdgeFilter.All);
        }

        public static void FillRoundedRectangle(this Graphics graphics, Brush brush, Rectangle rectangle, int radius, RectangleEdgeFilter filter)
        {
            graphics.FillRoundedRectangle(brush, (float)rectangle.X, (float)rectangle.Y, (float)rectangle.Width, (float)rectangle.Height, (float)radius, filter);
        }

        public static void FillRoundedRectangle(this Graphics graphics, Brush brush, RectangleF rectangle, int radius, RectangleEdgeFilter filter)
        {
            graphics.FillRoundedRectangle(brush, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height, (float)radius, filter);
        }

        public static void FillRoundedRectangle(this Graphics graphics, Brush brush, int x, int y, int width, int height, int radius)
        {
            graphics.FillRoundedRectangle(brush, Convert.ToSingle(x), Convert.ToSingle(y), Convert.ToSingle(width), Convert.ToSingle(height), Convert.ToSingle(radius));
        }

        public static void FillRoundedRectangle(this Graphics graphics, Brush brush, float x, float y, float width, float height, float radius)
        {
            graphics.FillRoundedRectangle(brush, x, y, width, height, radius, RectangleEdgeFilter.All);
        }

        public static void FillRoundedRectangle(this Graphics graphics, Brush brush, float x, float y, float width, float height, float radius, RectangleEdgeFilter filter)
        {
            RectangleF rectangle = new RectangleF(x, y, width, height);
            GraphicsPath path = graphics.GenerateRoundedRectangle(rectangle, radius, filter);
            SmoothingMode smoothingMode = graphics.SmoothingMode;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.FillPath(brush, path);
            graphics.SmoothingMode = smoothingMode;
        }

        private static GraphicsPath GenerateCapsule(this Graphics graphics, RectangleF rectangle)
        {
            GraphicsPath path = new GraphicsPath();
            try
            {
                float height;
                RectangleF ef;
                if (rectangle.Width > rectangle.Height)
                {
                    height = rectangle.Height;
                    SizeF size = new SizeF(height, height);
                    ef = new RectangleF(rectangle.Location, size);
                    path.AddArc(ef, 90f, 180f);
                    ef.X = rectangle.Right - height;
                    path.AddArc(ef, 270f, 180f);
                    return path;
                }
                if (rectangle.Width < rectangle.Height)
                {
                    height = rectangle.Width;
                    SizeF ef3 = new SizeF(height, height);
                    ef = new RectangleF(rectangle.Location, ef3);
                    path.AddArc(ef, 180f, 180f);
                    ef.Y = rectangle.Bottom - height;
                    path.AddArc(ef, 0f, 180f);
                    return path;
                }
                path.AddEllipse(rectangle);
                return path;
            }
            catch
            {
                path.AddEllipse(rectangle);
            }
            finally
            {
                path.CloseFigure();
            }
            return path;
        }

        private static GraphicsPath GenerateRoundedRectangle(this Graphics graphics, RectangleF rectangle, float radius, RectangleEdgeFilter filter)
        {
            GraphicsPath path = new GraphicsPath();
            if ((radius <= 0f) || (filter == RectangleEdgeFilter.None))
            {
                path.AddRectangle(rectangle);
                path.CloseFigure();
                return path;
            }
            if (radius >= (((double)Math.Min(rectangle.Width, rectangle.Height)) / 2.0))
            {
                return graphics.GenerateCapsule(rectangle);
            }
            float width = radius * 2f;
            SizeF size = new SizeF(width, width);
            RectangleF rect = new RectangleF(rectangle.Location, size);
            if ((RectangleEdgeFilter.TopLeft & filter) == RectangleEdgeFilter.TopLeft)
            {
                path.AddArc(rect, 180f, 90f);
            }
            else
            {
                path.AddLine(rect.X, rect.Y + rect.Height, rect.X, rect.Y);
                path.AddLine(rect.X, rect.Y, rect.X + rect.Width, rect.Y);
            }
            rect.X = rectangle.Right - width;
            if ((RectangleEdgeFilter.TopRight & filter) == RectangleEdgeFilter.TopRight)
            {
                path.AddArc(rect, 270f, 90f);
            }
            else
            {
                path.AddLine(rect.X, rect.Y, rect.X + rect.Width, rect.Y);
                path.AddLine(rect.X + rect.Width, rect.Y + rect.Height, rect.X + rect.Width, rect.Y);
            }
            rect.Y = rectangle.Bottom - width;
            if ((RectangleEdgeFilter.BottomRight & filter) == RectangleEdgeFilter.BottomRight)
            {
                path.AddArc(rect, 0f, 90f);
            }
            else
            {
                path.AddLine(rect.X + rect.Width, rect.Y, rect.X + rect.Width, rect.Y + rect.Height);
                path.AddLine(rect.X, rect.Y + rect.Height, rect.X + rect.Width, rect.Y + rect.Height);
            }
            rect.X = rectangle.Left;
            if ((RectangleEdgeFilter.BottomLeft & filter) == RectangleEdgeFilter.BottomLeft)
            {
                path.AddArc(rect, 90f, 90f);
            }
            else
            {
                path.AddLine(rect.X + rect.Width, rect.Y + rect.Height, rect.X, rect.Y + rect.Height);
                path.AddLine(rect.X, rect.Y + rect.Height, rect.X, rect.Y);
            }
            path.CloseFigure();
            return path;
        }      
    }

    public enum RectangleEdgeFilter
    {
        All = 15,
        BottomLeft = 4,
        BottomRight = 8,
        None = 0,
        TopLeft = 1,
        TopRight = 2
    }
}

