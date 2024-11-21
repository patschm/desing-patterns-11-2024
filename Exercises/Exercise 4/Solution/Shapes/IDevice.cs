namespace Shapes;

public interface IDevice
{
    void DrawCircle(Circle c);
    void DrawRectangle(Rectangle r);
    void DrawTriangle(Triangle t);
}

public interface IDevice_V2 : IDevice
{
    void DrawOctagonal(object obj);
}
