## Abstract Factory

One of the most common and used design patterns, it allows an interface to create families of related objects without specifying their concrete classes.

![UML Class Diagram](https://www.dofactory.com/images/diagrams/net/abstract.gif "UML Class Diagram")



- A customer (who will consume the resource) needs to know only the abstraction of the object creation factory, not its implementation.

- In this way the isolation of concrete classes is obtained, and if it is necessary to change any product (concrete class) or the whole family of classes, it will have a lesser impact on the other parts of the system, which should, in best practice, depend on abstractions, and not implementations.


Reference: [dofactory](https://www.dofactory.com/net/abstract-factory-design-pattern "dofactory")
