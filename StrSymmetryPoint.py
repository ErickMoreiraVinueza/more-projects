#Importo la libreria para calcular la complexity de tiempo.
import big_o

def StrSymmetryPoint(cadena_caracteres):
    """"
    Se crea la función para la resolución de encontrar una simetría en la cadena si existiese.
    
    Parámetros:
    -------------------
    Recibe la variable
    str = cadena_caracteres que ha digitado el usuario

    Retorna:
    -------------------
    Retorna la variable 
    int = numero_no_repetido que corresponde al término que estamos buscando.
    """   
    #Calculo el tamaño de mi cadena ingresada
    tamanio_cadena = len(cadena_caracteres)
    #Solo puede haber simestría si la cadena es impar, por lo tanto si el módulo es 0 quiere decir que la cadena es par, por lo tanto
    #retorno el -1.
    if(tamanio_cadena % 2 == 0):
        return -1
    #En este caso si solo tengo un caracter retorno 0 como dice el problema dado que no tendría demás caracteres en la cadena.
    if(tamanio_cadena == 1):
        return 0
    #Separo la cadena a la mitad
    mitad_cadena = int(tamanio_cadena/2)
    inicio = 0
    final = tamanio_cadena - 1
    for i in range(inicio,final):
        if(cadena_caracteres[inicio] != cadena_caracteres[final]):
            return -1
        inicio = inicio + 1
        final = final - 1
    return mitad_cadena



#if main de nuestro programa dónde solo ejecuto la función correspondiente.
if __name__ == '__main__':
    cadena_caracteres = input('Escriba una palabra para realizar el proceso: ')
    print('El valor es',StrSymmetryPoint(cadena_caracteres))