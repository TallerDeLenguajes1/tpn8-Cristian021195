a) Objetos del tipo LinkedList y List, ¿Cuales son las diferencias que tienen?
    ->LINKED LIST: son listas enlazadas.
    La diferencia con las listas que habitualmente conocemos es de eficiencia, son parecidas,
     en ambas podemos agregar y eliminar elementos, recorrerlas.

    La diferencia radica en su funcionamiento interno.
    Si tenemos una LISTA CLASICA podemos ir agregando datos (variables, objetos, etc.) 
    Agregamos cada elemento en una posiccion concreta de la memoria.
    Siempre se agregan los elementos en posiciones adyacentes a medida que se van creando.
    Al eliminar un elemento, queda vacia esa posicion de la memoria. 
    Pero esto no puede ser asi porque siemrpe deben estar juntos. 
    Todos los datos adyacentes deben ser movidos y es alli donde esta la diferencia si tenemos
    una lista muy extensa y eliminamos solo un elemnto, debemos mover cada elemento una posicion y es
    alli donde pierde eficacia.

    LINKED LIST
    Esta compuesta por polos, o enlaces. dos enlaces que conectan con el siguiente elemento y con el anterior.
    estos nodos son objetos (Es practicamente lo mismo que vimos a comienzo de la materia en C, pero ahora
    podemos incluir objetos y otros datos).
        LinkedListNode<Tipo de dato>
    Estos datos no necesariamente tienen que estar posicionados de forma adyacente en la memoria.
    Es mas eficiente, solo se actualizan los links, no se desplazan los datos en la memoria.
    Solo son los enlaces que apuntan a diferentes posiciones o nodos al momento de eliminar o agregar uno
    en alguna posicion en particular.

b) Objeto Diccionario: Dicctionary<Tkey, Tvalue>
    El objeto diccionario es un tipo de dato similar a los arrays asociativos de PHP, trabajan con una clave unica y un valor.
    Diccionary<Tkey, Tvalue> dic = new Diccionary<Tkey, Tvalue>();
    Las claves no pueden ser repetidas.
    La forma de recorrerlos es por un metodo foreach pasando como referencia KeyValuePair<Tkey, Tvalue> elemento in dic.

c) Beneficios de usar una biblioteca, por que pondria una clase en una biblioteca y cuando agregaria
    directamente la clase en su proyecto

    ->  BIBLIOTECA: Tambien conocido como libreria.
    Sirve para reutilizacion de codigo.
    La forma de usarlas es importarlas a nuestros proyectos/espacios de trabajo.
    La ventaja de crear nuestras propias bibliotecas es que podemos tener un mejor orden. y tambien la ventaja de escalar nuestro proyecto. si
    asi lo requiere.

    ->  Usaria clases en caso de que sean muy propias del proyecto, y quizas no sean de gran utilidad en otros proyectos o programas.
    Las librerias (siendo un conjunto de clases con metodos propios) normalmente es de uso generico, Vemos al momento de crearla
    que nos puede ser de gran utilidad para otros proyectos o programas. y directamente solo importamos y hacemos referencia a la libreria
    .dll creada por nosotros.

d) como se agrega la referencia a una biblioteca de clase en su proyecto

    ->  Lo agregamos como un nuevo proyecto, el asistente nos indica, Biblioteca de clases (.NET Framework)
    Nos da un namespace que agregamos, y la clase por defecto es class1, la cual la renombramos con nuestra preferencia.
    En estas clases es donde ponemos nuestros atributos, privados, publicos, y metodos propios creados por nosotros.
    Al momento de importar. no solo hacemos referencia el nombre de la biblioteca, sino tambien al namespace.
    Al momento de compilar, no es un programa que corre, pero si nos genera un archivo .dll (dynamic-link library) o biblioteca de enlace dinamico.
    Tenemos que agregar una referencia con el asistente(click derecho en VS) y luego hacemos uso de using y El nombre del namespace de la biblioteca.
