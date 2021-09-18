#pragma once

struct Point
{
    int x;
    int y;
};

[[nodiscard]] bool operator == (const Point& a, const Point& b);