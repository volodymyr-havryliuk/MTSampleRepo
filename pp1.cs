static string Display(object o) => o switch
{
    Point { X: 0, Y: 0 }         p => "origin",
    Point { X: var x, Y: var y } p => $"({x}, {y})",
    _                              => "unknown"
};