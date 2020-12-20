using System;

/// <summary> Outline of a shape. </summary>
class Shape {
    /// <summary> Calculates the area of the shape. </summary>
    public virtual int Area() {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary> Outline of a rectangle. </summary>
class Rectangle : Shape {
    private int width;
    private int height;

    /// <summary> The width of the rectangle. </summary>
    public int Width {
        get { return width; }
        set {
            if (value < 0) {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            width = value;
        }
    }
    
    /// <summary> The height of the rectangle. </summary>
    public int Height {
        get { return height; }
        set {
            if (value < 0) {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            height = value;
        }
    }

    /// <summary> Calculates the area of the rectangle. </summary>
    public new int Area() {
        return width * height;
    }

    /// <summary> Returns the string representation of the rectangle. </summary>
    public override string ToString() {
        return $"[Reactangle] {width} / {height}";
    }
}

/// <summary> Outline of a Square. </summary>
class Square : Rectangle {
    private int size;

    /// <summary> The size of the square. </summary>
    public int Size {
        get { return size; }
        set {
            if (value < 0) {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
            size = value;
            Height = value;
            Width = value;
        }
    }

    /// <summary> Returns the string representation of the square. </summary>
    public override string ToString() {
        return $"[Square] {size} / {size}";
    }
}
