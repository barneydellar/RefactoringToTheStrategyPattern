#include "pch.h"
#include "Shape.h"

Shape::Shape(const Type t) : m_type(t) {}

void Shape::Draw(ICanvas& canvas) const
{
    canvas.DrawVertex({ 0, 0 });
    canvas.DrawVertex({ 2, 0 });
    if (m_type == Type::Triangle) {
        canvas.DrawVertex({ 1, 2 });
    }
    else {
        canvas.DrawVertex({ 0, 2 });
        canvas.DrawVertex({ 2, 2 });
    }
    if (m_type == Type::Pentagon) {
        canvas.DrawVertex({ 1, 3 });
    }
    else if (m_type == Type::Hexagon)
    {
        canvas.DrawVertex({ 3, 1 });
        canvas.DrawVertex({ -1, 1 });
    }
}

