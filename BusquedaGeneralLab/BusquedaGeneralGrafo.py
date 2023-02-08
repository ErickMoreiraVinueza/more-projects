#Definimos nuestra clase en la que vamos a definir nuestros nodos.
class definir_nodo:

    """
    La funcion __init__() se usa aqui en Python para definir un constructor.
    Parametos:
    ----------
    Las variables:
    self: variable para utilizar los metodos del constructor.
    nombre: variable que corresponde al nombre respectivo de cada nodo.
    Retorna:
    --------
    No retorna ningun valor
    """

    #Creamos nuestro constructor.
    def __init__(self, nombre):
        #Corresponde al nombre de cada nodo.
        self.id = nombre
        #Corresponde a los nodos que esten conectados uno con el otro.
        self.conectados = []

    """
    La funcion agregarNodoConectado() sirve para ir agregando los nodos que se encuentren a un lado del otro para ir relacionandonos entre si.
    Parametos:
    ----------
    Las variables:
    self: variable para utilizar los metodos del constructor.
    nombre_conectado: variable que corresponde al nombre respectivo de cada nodo paralelo al otro.
    Retorna:
    --------
    No retorna ningun valor
    """

    def agregarNodoConectado(self, nombre_conectado):
        #Mediante el if preguntamos si el nodo conectado ya se encuentra en esa lista, si es así se deja pasar. 
        if nombre_conectado in self.conectados:
            pass
        #Caso contrario lo vamos a agregar con el método append.
        else:
            self.conectados.append(nombre_conectado)

#Definimos nuestra clase en la que vamos a establecer nuestros nodos.
class establecer_nodos:

    """
    La funcion __init__() se usa aqui en Python para definir un constructor.
    Parametos:
    ----------
    Las variables:
    self: variable para utilizar los metodos del constructor.
    Retorna:
    --------
    No retorna ningun valor
    """

    #Creamos nuestro constructor.
    def __init__(self):
        #Creamos un diccionario para establecer nuestro nodos con sus identificadores. 
        self.nodos= {}

    """
    La funcion agregarConexionNodos() sirve para ir agregando los nodos que tengan relacion entre si a un diccionario que utilizamos para 
    almacenar este tipo de datos.
    Parametos:
    ----------
    Las variables:
    self: variable para utilizar los metodos del constructor.
    nombre_conectado: variable que corresponde al nombre respectivo de cada nodo paralelo al otro.
    Retorna:
    --------
    No retorna ningun valor
    """

    def agregarConexionNodos(self, nombre_conectado):
        #Mediante el if preguntamos si el nodo conectado ya se encuentra en este caso en el diccionario, si es así se deja pasar. 
        if nombre_conectado in self.nodos:
            pass
        #Caso contrario lo vamos a agregar como un elemento del diccionario, correspondiente a un objetivo de tipo definir_nodo en este caso.
        else:
            self.nodos[nombre_conectado] = definir_nodo(nombre_conectado)

    """
    La funcion agregarConexion() sirve para ir conectando los nodos entre si mediante las aristas como se las conoce en la teoria.
    Parametos:
    ----------
    Las variables:
    self: variable para utilizar los metodos del constructor.
    nodo_1: variable correspondiente a uno de los nodos que van a ser relacionados mediante sus aristas.
    nodo_2: variable correspondiente al otro nodo que esta relacionado con el primero.
    Retorna:
    --------
    No retorna ningun valor
    """

    def agregarConexion(self, nodo_1, nodo_2):
        #Mediante el if preguntamos si ambos nodos se encuentran ya en nuestro diccionario.
        if nodo_1 in self.nodos and nodo_2 in self.nodos:
            #Si es asi se procede a conectarlos uno con el otro en ambos sentidos.
            self.nodos[nodo_1].agregarNodoConectado(nodo_2)
            self.nodos[nodo_2].agregarNodoConectado(nodo_1)

#Main de nuestro programa para correr el algoritmo.
if __name__ == '__main__':
    #Se crea una variable de tipo de la clase establecer_nodos.
    Nodo = establecer_nodos()
    #Se establece los nombres correspondiente de cada nodo.
    lista_nodos = ['Portoviejo','Mejia','Rio Chico','Sosote','Pechiche','San Clemente','Rocafuerte','La Sequita','San Eloy','Cañitas','Charapotó',
    'El Pueblito','La Boca']
    #Vamos agregando cada nodo mediante el ciclo for
    for n in lista_nodos:
        Nodo.agregarConexionNodos(n)

    #Se establece los nodos correspondientes a ambas rutas.
    lista_conexiones = ['Portoviejo', 'Mejia', 'Portoviejo', 'Rio Chico', 'Mejia', 'Sosote', 'Rio Chico', 'Pechiche', 'Sosote', 'Rocafuerte', 
    'Pechiche', 'San Clemente', 'San Clemente', 'Rocafuerte', 'Rocafuerte', 'La Sequita', 'Rocafuerte', 'San Eloy', 'La Sequita', 'Charapotó', 
    'San Eloy', 'Cañitas', 'Cañitas', 'Charapotó', 'Charapotó', 'El Pueblito',  'El Pueblito', 'La Boca', 'La Boca']
    #Vamos recorriendo desde la primera hasta la ultima posicion de nuestros nodos ya enlazados, recorriendo de 2 en 2.
    for i in range(0,len(lista_conexiones) - 1, 2):
        Nodo.agregarConexion(lista_conexiones[i], lista_conexiones[i+1])
    #Vamos imprimiendo cada uno de los nodos con sus conexiones.
    for nodo in Nodo.nodos:
        print(nodo, Nodo.nodos[nodo].conectados)
        print('')
    print('---El costo más corto para la trayectoria es de 7 pasos---')        
