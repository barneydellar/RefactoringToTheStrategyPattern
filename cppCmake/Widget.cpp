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
    canvas.DrawVertex({ 0, 0 });
    canvas.DrawVertex({ 2, 0 });
    if (m_type == Type::Triangle) {
        canvas.DrawVertex({ 1, 2 });
    }
    else {
        canvas.DrawVertex({ 0, 2 });
        canvas.DrawVertex({ 2, 2 });
    }

    switch (m_type) {
    case Type::Pentagon:
        canvas.DrawVertex({ 1, 3 });
        break;
    case Type::Hexagon:
        canvas.DrawVertex({ 3, 1 });
        canvas.DrawVertex({ -1, 1 });
        break;
    }
}

void Widget::SetType(const Type type)
{
    m_type = type;
}
