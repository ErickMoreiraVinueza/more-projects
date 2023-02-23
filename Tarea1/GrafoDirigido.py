#Diccionario que contiene los nombres respectivos de cada nodo y su relación con los demás.
grafo = {'Plaza del Sol': ['City Plaza'],
             'City Plaza': ['Plaza Victoria', 'Plaza Alianza'],
             'Plaza Alianza': ['Plaza Victoria'],
             'Plaza Eva': ['Plaza Alianza']}

"""
    La funcion encontrar_rutas() sirve para encontrar las rutas correspondientes para llegar de Plaza del Sol a Plaza Victoria.
    Parametos:
    ----------
    Las variables:
    grafo: diccionario que contiene el nodo y su relación.
    inicia: nodo donde inicia el recorrido.
    termina: nodo donde termina el recorrido.
    ruta[]: lista que corresponde a la ruta de un nodo sin movimiento.
    Retorna:
    --------
    rutas[]: lista que corresponde a la respuesta de las rutas para llegar desde el punto inicial hasta el destino.
    """
def encontrar_rutas(grafo, inicia, termina, ruta=[]):
        ruta = ruta + [inicia]
        #Condición en caso que el nodo inicial sea el mismo que el final.
        if inicia == termina:
            return [ruta]
        #Condición si no existe un nodo inicial.
        if not grafo.__contains__(inicia):
            return []
        rutas = []
        #Recorriendo los nodos.
        for nodo in grafo[inicia]:
            if nodo not in ruta:
                #Voy creando la nueva ruta de respuesta.
                nuevas_rutas = encontrar_rutas(grafo, nodo, termina, ruta)
                for nueva_ruta in nuevas_rutas:
                    #Voy agregando la respuesta a la lista rutas[]
                    rutas.append(nueva_ruta)
        #Retorno la lista rutas[] correspondiente a la respuesta.
        return rutas

#Main de nuestro programa para correr el algoritmo.
if __name__ == '__main__':
    print(encontrar_rutas(grafo, 'Plaza del Sol', 'Plaza Victoria'))