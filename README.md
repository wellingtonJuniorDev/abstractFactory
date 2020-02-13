## Abstract Factory

Um dos design patterns mais comuns e utilizados, fornece uma interface para criar famílias de objetos relacionados sem especificar suas classes concretas.

![Diagrama de classe UML](https://www.dofactory.com/images/diagrams/net/abstract.gif "Diagrama de classe UML")



- Um cliente (quem irá consumir o recurso) necessita conhecer somente a abstração da fábrica de criação de objetos, não sua implementação.

- Desta forma se obtém o isolamento de classes concretas, e se for necessário trocar algum produto (classe concreta) ou toda a família de classes, causará um impacto menor nas demais partes do sistema, que deverá na melhor prática, depender das abstrações, e não implementações.


Referência: [dofactory](https://www.dofactory.com/net/abstract-factory-design-pattern "dofactory")
