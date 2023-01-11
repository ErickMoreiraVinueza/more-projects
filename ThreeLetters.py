#Importo la libreria para calcular la complexity de tiempo.
import big_o
#Importo la libreria para genera mi cadena aleatoria.
import random

def ThreeLetters(primer_entero,segundo_entero):
    """"
    Se crea la función para la resolución de la cadena aleatoria a partir de la cantidad de letras "a" y "b" que elija el usuario
    que aparezcan en la cadena.
    
    Parámetros:
    -------------------
    Recibe la variable
    int = primer_entero que ha digitado el usuario
    int = segundo_entero que ha digitado el usuario

    Retorna:
    -------------------
    Retorna la variable 
    str = cadena_aleatoria que sería el string aleatorio generado a partir de la cantidad de letras "a" y "b" que haya elegido el
    usuario que aparezcan en dicha cadena.
    """ 
    #Genero los caracteres que aparecerán en la cadena.
    primer_caracter = "a" 
    segundo_caracter = "b"
    #Genero la lista donde voy a almacenar la cantidad de letras que elija el usuario.
    cadena1 = []
    cadena2 = []
    #Voy agregando la cantidad de letras "a" elegidas a la lista.
    for i in range(primer_entero):
        cadena1.append(primer_caracter)
    #Voy agregando la cantidad de letras "b" elegidas a la lista.
    for j in range(segundo_entero):
        cadena2.append(segundo_caracter)
    #Concateno las letras de ambas listas para imprimirlas en pantalla.
    lista_cadena = cadena1 + cadena2
    print(lista_cadena)
    #Mediante el método random mezclo los caracteres para generar mi cadena aleatoria
    lista_aleatoria = random.sample(lista_cadena,k=len(lista_cadena))
    #Convierto mi lista en una cadena string mediante el método join.
    cadena_aleatoria = "".join(lista_aleatoria)
    #Genero la condición para evitar que se repitan 3 letras iguales sea "a" o "b" como menciona el problema.
    for k in lista_aleatoria:
        if(lista_aleatoria[0] == lista_aleatoria[1] and lista_aleatoria[1] == lista_aleatoria[2] and lista_aleatoria[2] == lista_aleatoria[3]):
            print('Repetido')
            SystemExit()
    #Retorno mi string aleatorio con la condición de los repetidos.
    return cadena_aleatoria
        
#if main de nuestro programa dónde solo ejecuto la función correspondiente.
if __name__ == '__main__':
    primer_entero = int(input('Ingrese la cantidad de letras "a" que desea en la cadena: '))
    segundo_entero = int(input('Ingrese la cantidad de letras "b" que desea en la cadena: '))
    print("La cadena aleatoria es la siguiente",ThreeLetters(primer_entero,segundo_entero))
    cadena_ejemplo = lambda example_variable: 'Ejemplo'
    best, others = big_o.big_o(ThreeLetters, cadena_ejemplo)
    print(best)