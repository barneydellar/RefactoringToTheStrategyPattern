#include "pch.h"
#include "Widget.h"
#include "ICanvas.h"

std::string Widget::Describe() const
{
    if (m_type == Type::Triangle) {
        return "Triangle";
    }
    else if (m_type == Type::Square) {
        return "Square";
    }
    else if (m_type == Type::Pentagon) {
        return "Pentagon";
    }
    else if (m_type == Type::Hexagon) {
        return "Hexagon";
    }
    return "";
}

void Widget::Draw(ICanvas& canvas) const
{
    switch (m_type) {
    case Type::Triangle:
        canvas.DrawVertex({ 0, 0 });
        canvas.DrawVertex({ 2, 0 });
        canvas.DrawVertex({ 1, 2 });
        break;
    case Type::Square:
        canvas.DrawVertex({ 0, 0 });
        canvas.DrawVertex({ 0, 2 });
        canvas.DrawVertex({ 2, 2 });
        canvas.DrawVertex({ 2, 0 });
        break;
    case Type::Pentagon:
        canvas.DrawVertex({ 0, 0 });
        canvas.DrawVertex({ 2, 0 });
        canvas.DrawVertex({ 2, 2 });
        canvas.DrawVertex({ 1, 3 });
        canvas.DrawVertex({ 0, 2 });
        break;
    case Type::Hexagon:
        canvas.DrawVertex({ 0, 0 });
        canvas.DrawVertex({ 2, 0 });
        canvas.DrawVertex({ 3, 1 });
        canvas.DrawVertex({ 2, 2 });
        canvas.DrawVertex({ 0, 2 });
        canvas.DrawVertex({ -1, 1 });
        break;
    }
}

void Widget::SetType(const Type type)
{
    m_type = type;
}
