### Diagrama _UML_
```mermaid
classDiagram
    class Color{
    -red: byte 
    -green: byte
    -blue: byte
    -alpha: byte
    +Color(byte)
    +ShowColor(byte)
    +Red: byte
    +Green: byte
    +Blue: byte
    +SetGrey: byte
    -GetGrey() byte
    }

    class Sphere{
    -raio: int
    -cor: readonly
    -vezes_atirado: int
    
    +Sphere(int,Color)
    +Pop() int
    +Throw() int
    +GetTimesThrown() int
    }

    class Program{
    
    }

    Color --> Sphere
    Sphere --> Program
    Color --> Program
    

    




    