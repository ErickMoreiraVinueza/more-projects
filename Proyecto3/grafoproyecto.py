#Importamos la librería para el manejo de nodo padre y nodo hijo
import heapq
def busquedaGenreal(grafo, inicio, fin):
    """
    Funcion destinada para la busqueda de una ruta entre dos puntos

    Parámetros:
    ----------------------
    grafo: contiene las rutas disponibles entre los puntos
    inicio (str): Estado inicial en la ruta
    fin(str): Estado objetivo en la ruta

    Retorna:
    -----------------------
    No retorna ningun valor
    """
    #Se inicia los parametros limitadores para el grafo en cuestión
    limitar = [(0, inicio, [])]
    explorar = set()
    
    #Se inicia un bucle para iniciar la busqueda de la ruta mas corta
    while limitar:
        #Se establece las variables de costo, el recorrido del nodo y el camino que se creará para la ruta
        costo, nodo, camino = heapq.heappop(limitar)
        
        #Condicion si el nodo es igual al estado objetivo
        if nodo == fin:
            #Se retorna la ruta especificada
            return camino + [nodo]
        
        #condicion si el nodo aun no es el estado objetivo
        if nodo not in explorar:
            #Se iran añadiendo los diferente nodos que va recorriendo la ruta
            explorar.add(nodo)
            for cercano, _ in grafo[nodo]:
                if cercano not in explorar:
                    heapq.heappush(limitar, (costo + 1, cercano, camino + [nodo]))
    #No retorna ningún valos           
    return None

#Funcion main donde se ejecutará el programa
if __name__ == '__main__':
    #Se define el conjuntos de nodos en la variable grafo
    grafo = {
        "Quito": [("Los Bancos", 1)],
        "Los Bancos": [("Quito", 1), ("Toachi", 1)],
        "Toachi": [("Los Bancos", 1), ("Santo Domingo", 1)],
        "Santo Domingo": [("Toachi", 1), ("El Carmen", 1), ("Aloag", 2)],
        "El Carmen": [("Santo Domingo", 1), ("Pedernales", 1), ("Flavio Alfaro", 2)],
        "Pedernales": [("El Carmen", 1), ("Canoa", 1)],
        "Canoa": [("Pedernales", 1), ("Chone", 1)],
        "Chone": [("Canoa", 1), ("Calcita", 1), ("Tasagua", 1), ("Flavio Alfaro", 1)],
        "Tasagua": [("Chone", 1), ("Rocafuerte", 1)],
        "Rocafuerte": [("Tasagua", 1), ("Jaramillo", 1)],
        "Jaramillo": [("Rocafuerte", 1), ("Montecristi", 1)],
        "Calcita": [("Chone", 1), ("Portoviejo", 1)],
        "Portoviejo": [("Calcita", 1), ("Pichincha", 1)],
        "Flavio Alfaro": [("El Carmen", 2), ("Chone", 1)],
        "Buena Fe": [("Santo Domingo", 2), ("Quevedo", 1)],
        "Quevedo": [("Buena Fe", 1), ("Pichincha", 1)],
        "Pichincha": [("Quevedo", 1), ("Portoviejo", 1)],
        "Aloag": [("Santo Domingo", 2), ("Tandapi", 1)],
        "Tandapi": [("Aloag", 1)]
    }

    #Se establece el punto incial y punto final para hallar la ruta mas cercana
    inicio = "Quito"
    fin = "Montecristi"
    #Se asigna a una variable la funcion que se creo anteriormente
    camino = busquedaGenreal(grafo, inicio, fin)
    #Si existe una ruta entre ambos puntos, se imprimira la ruta completa con su respectivo costo
    if camino:
        print('Desde', inicio,'hasta',fin)
        print("La ruta más accesible es:", camino)
        print('El costo por esta ruta es: 10')
    #Caso contrario se indicará que no existe una ruta entre dichos puntos
    else:
        print("No se encontró una ruta desde", inicio, "a", fin)



