#Importo la libreria para calcular la complexity de tiempo.
import big_o



def FirtsUnique(numero_Elementos):
    """"
    Se crea la función para la resolución de encontrar el primer número único es decir que no se repita  dentro de una lista que digite 
    el usuario.
    
    Parámetros:
    -------------------
    Recibe la variable
    int = numero_elementos que ha digitado el usuario

    Retorna:
    -------------------
    Retorna la variable 
    int = numero_no_repetido que corresponde al término que estamos buscando.
    """    
    #Creo una lista para almacenar los elementos que digite el usuario.
    lista_enteros = []
    #Implemento un ciclo for el cual empieza desde un primer valor y termina dependiendo del número de elementos que el usuario haya
    #elegido agregar.
    for i in range(0,numero_Elementos):
        #Pido el elemento de acuerdo a su posición.
        print("Elemento",i+1,":")
        elementos = int(input())
        #Voy ingresando cada elemento que digite el usuario a mi lista mediante el método append.
        lista_enteros.append(elementos)
        #Una vez que terminar de ingresar los elementos a la lista realizo la eliminación de los elementos repetidos.
    #Inicializo la variable para luego almacenar aquí la respuesta.
    numero_no_repetido = 0
    #Mediante otro ciclo for voy recorriendo la lista de los elementos agregados por el usuario.
    for j in range(0,len(lista_enteros)):
        #Utilizo el método count para contar cuantas se veces se repite un elemento dentro de la lista, si solo es una vez almaceno
        #la posición de ese elemento dentro de la variable numero_no_repetido y enseguida termino la instrucción con un break
        #para así mostrar el primero valor que cumplió la característica.
        if(lista_enteros.count(lista_enteros[j]) == 1):
            numero_no_repetido = lista_enteros[j]
            break

    #Retorno el valor encontrado.
    return numero_no_repetido
    

#if main de nuestro programa dónde solo ejecuto la función correspondiente.
if __name__ == '__main__':
    numero_Elementos = int(input('Ingrese el numero de elementos: '))
    print('El primer número único es',FirtsUnique(numero_Elementos))
    numero_sample = lambda example_variable: numero_Elementos
    best, others = big_o.big_o(FirtsUnique, numero_sample)
    print(best)