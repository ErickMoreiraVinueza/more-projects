#Importo la libreria para calcular la complexity de tiempo.
import big_o
def leerVariable():
    """"
    Se crea la función para la lectura del número entero positivo que digite el usuario y va a ser requerido para hallar la potencia
    más alta.
    
    Parámetros:
    -------------------
    No recibe ningún valor.

    Retorna:
    -------------------
    Retorna la variable 
    int = entero_positivo que ha digitado el usuario.
    """
    #Solicito al usuario el número entero positivo.
    entero_positivo = int(input('Ingrese el número entero positivo: '))
    #Retorno la variable para usarla como parámetro de mi siguiente función.
    return entero_positivo

def ParityDegree(entero_positivo):
    """"
    Se crea la función para la resolución de 2 elevada la potencia más alta siempre cuando el módulo del valor ingresado por este 
    resultado siga siendo 0.
    
    Parámetros:
    -------------------
    Recibe la variable
    int = entero_positivo que ha digitado el usuario

    Retorna:
    -------------------
    Retorna la variable 
    int = potencia_maxima-1 dado que el ciclo for aumentará un valor extra de la respuesta correcta.
    """    
    #Inicializo la variable potencia_maxima
    potencia_maxima = 0
    #Creo mi ciclo for va desde el entero_positivo + 1 ya que el range no toma en cuenta este valor como parte final de su rango y por
    #eso le sumo 1.
    for i in range(entero_positivo+1):
        #Almaceno en la variable resultado el 2 elevado a la potencia que se va a ir incrementando.
        resultado = 2**potencia_maxima
        #Genero la condición para cuando ya el módulo del valor ingresado y el de la variable resultado sean diferentes de 0 quiere
        #decir que se llegó al máximo exponente, por lo cual retorno la variable que vendría a ser mi respuesta.
        if(entero_positivo % resultado != 0):
            return potencia_maxima-1
        #Voy incrementando mi variable potencia_maxima hasta encontrar la respuesta correcta.
        potencia_maxima = potencia_maxima + 1

#if main de nuestro programa dónde solo ejecuto la función correspondiente.
if __name__ == '__main__':
    entero_positivo = leerVariable()
    print("El mayor exponente fue",ParityDegree(entero_positivo))
    numero_sample = lambda example_variable: entero_positivo
    best, others = big_o.big_o(ParityDegree, numero_sample)
    print(best)