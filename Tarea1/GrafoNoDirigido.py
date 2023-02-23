#Diccionario que contiene los nombres respectivos de cada nodo y su relación con los demás.
grafo = { "1" : {"2",'3'},
          "2" : {"1", "3",'4'},
          "3" : {"1", "2",},
          "4" : {"2"}}

"""
    La funcion generar_arcos() sirve para encontrar las relaciones correspondientes entre cada nodo bidireccional.
    Parametos:
    ----------
    Las variables:
    grafo: diccionario que contiene el nodo y su relación.
    Retorna:
    --------
    arcos[]: lista que corresponde a la respuesta de las relaciones entre cada nodo.
"""
def generar_arcos(grafo):
    arcos = []
    #Recorriendo los nodos.
    for nodo in grafo:
        #Voy buscando las relaciones y agregando las respuestas a la lista arcos[]
        for vecino in grafo[nodo]:
            arcos.append({nodo, vecino})
    #Retorno la lista arcos[] correspondiente a la respuesta.
    return arcos

#Main de nuestro programa para correr el algoritmo.
if __name__ == '__main__':
    print(generar_arcos(grafo))