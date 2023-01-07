#Importo la función que me sirve para usar el método reduce y así poder utilizarla y realizar la resta, multiplicación y división.
from functools import reduce
def leerVariables():
    """"
    Se crea la función para la lectura del número de elementos para los que se desea calcular las operaciones aritméticas para que así
    sea genérico.
    
    Parámetros:
    -------------------
    No recibe ningún valor.

    Retorna:
    -------------------
    Retorna la variable num_elementos que ha digitado el usuario.
    """
    #Solicito al usuario el número de veces para los que desea hacer los cálculos.
    num_elementos = int(input('Ingrese el número de elementos para los que desea realizar las operaciones básicas: '))
    #Retorno la variable para usarla como parámetro en la siguiente función.
    return num_elementos

def restar(x,y): 
    """"
    Se crea la función genérica para así usarla en el método reduce y poder restar los valores.
    
    Parámetros:
    -------------------
    Recibe variables genéricas para la resta.

    Retorna:
    -------------------
    Retorna la resta ya realizada.
    """
    return x-y

def multiplicar(x,y): 
    """"
    Se crea la función genérica para así usarla en el método reduce y poder multiplicar los valores.
    
    Parámetros:
    -------------------
    Recibe variables genéricas para la multiplicacion.

    Retorna:
    -------------------
    Retorna la multiplicacion ya realizada.
    """
    return x*y

def dividir(x,y):
    """"
    Se crea la función genérica para así usarla en el método reduce y poder dividir los valores.
    
    Parámetros:
    -------------------
    Recibe variables genéricas para la division.

    Retorna:
    -------------------
    Retorna la division ya realizada.
    """
    return x/y

def calculadorOperaciones(num_elementos):
    """"
    Se crea la función para el cálculo de la suma, resta, multiplicación y división según los elementos que haya digitado el usuario.
  
    Parámetros:
    -------------------
    Recibe la variable num_elementos correspondiente a las veces que se desee calcular.

    Retorna:
    -------------------
    No retorna ningún valor.
    """
    if(num_elementos >= 2):
        print("-----Bienvenido a la calculadora de operaciones aritméticas básicas-----")
        #Genero mi lista para ir guardando los elementos que digite el usuario.
        elementos = []
        #Genero mi ciclo for que va a durar hasta el número de elementos que haya elegido digitar el usuario.
        for i in range(0,num_elementos):
            #Almaceno los valores correspondientes.
            print('\nIngrese el valor',i+1)
            numero = float(input())
            #Voy ingresando cada elemento a mi lista, para hacer las operaciones.
            elementos.append(numero)
        #Realizo el cálculo de la suma.
        suma = sum(list(elementos))
        #Realizo el cálculo de la resta, multiplicacion y division con el metodo reduce que recibe como parametro la funcion generica 
        # restar, multiplicar y dividir y la lista de elementos correspondientes para realizar las operaciones.
        resta = reduce(restar,elementos)
        multiplicacion = reduce(multiplicar,elementos)
        division = reduce(dividir,elementos)
        #Imprimo los resultados de los elementos.
        print('\nLa suma de los elementos es',suma)
        print('La resta de los elementos es',resta)
        print('La multiplicacion de los elementos es',multiplicacion)
        print('La division de los elementos es',division)
    else:
        print("Ingrese un valor correcto, recuerde que debe haber mínimo dos elementos")

#if main de nuestro programa dónde solo ejecuto la función correspondiente.
if __name__ == '__main__':
    num_elementos= leerVariables()
    calculadorOperaciones(num_elementos)