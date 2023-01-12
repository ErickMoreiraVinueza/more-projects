#Importo la libreria para calcular la complexity de tiempo.
import big_o
#Importo la libreria para poder utilizar las horas en el formato correspondiente.
from datetime import datetime

def ParkingBill(hora_entrada, hora_salida):
    """"
    Se crea la función para la resolución del cálculo del total de pago dado las horas que un auto pasó en el estacionamiento.
    
    Parámetros:
    -------------------
    Recibe la variable
    int = hora_entrada que ha digitado el usuario
    int = hora_salida que ha digitado el usuario

    Retorna:
    -------------------
    Retorna la variable 
    int = costo_factura que sería el total que el usuario debe cancelar dado el tiempo que estuvo en el estacionamiento.
    """
    #Declaro las variables con unas horas estipuladas que me sirven para generar la condición en caso de que pase una hora o menos
    #en el estacionamiento.
    una_hora = "01:00"
    dos_horas = "02:00"
    #Transformo estas variables, incluidas las horas que digita el usuario en el formato correspondiente, es decir de tipo de string
    #a un formato HH:MM gracias al método strptime de la librería datetime.
    una_hora_tiempo = datetime.strptime(una_hora, '%H:%M')
    dos_hora_tiempo = datetime.strptime(dos_horas, '%H:%M')
    H_entrada = datetime.strptime(hora_entrada, '%H:%M')
    H_salida = datetime.strptime(hora_salida, '%H:%M')
    #Inicializo las variables que son tarifas constantes del estacionamiento.
    tarifa_entrada = 2
    primera_hora = 3
    siguientes_horas = 4
    #En la variable diferencia_horas calculo el total de tiempo que el auto pasó en el estacionamiento, se guarda como tipo string.
    diferencia_horas = H_salida - H_entrada
    #Utilizo las horas estipuladas que se mencionaron anteriormente que al restarse se guardará como tipo string para poder utilizarlo
    #en mi condición if.
    diferencia_horas_2 = dos_hora_tiempo - una_hora_tiempo
    #En mi condicional if comparo si el tiempo que el auto estuvo en el estacionamiento fue una hora completa o parcial.
    if(diferencia_horas <= diferencia_horas_2):
        #Si fue así solo retorno el costo correspondiente.
        costo_factura = tarifa_entrada + primera_hora
        return costo_factura
    else:
        #Convierto el tiempo que el auto estuvo en el estacionamiento en un string para poder convertirlo nuevamente en el formato
        #HH:MM
        diferencia_horas_str = str(diferencia_horas)
        diferencia_horas_tiempo = datetime.strptime(diferencia_horas_str, '%H:%M:%S')
        #Obtengo el valor solo de las horas que el auto pasó en el estacionamiento mediante .hour para poder obtener el costo total
        #en caso de que haya pasado más de una hora.
        horas_restantes = diferencia_horas_tiempo.hour
        #Encuentro el costo total en este caso multiplicado por las horas extras que el auto estuvo en el estacionamiento sean completas
        #o parciales.
        costo_factura = tarifa_entrada + primera_hora + (siguientes_horas*horas_restantes)
        return costo_factura

#if main de nuestro programa dónde solo ejecuto la función correspondiente.
if __name__ == '__main__':
    print("No olvide que al ingresar los datos el formato de horas y minutos debe ser el siguiente -> HH:MM, ejemplo: 12:35")
    hora_entrada = input('Ingrese la hora que ingresó el automóvil al estacionamiento: ')
    hora_salida = input('Ingrese la hora que el automóvil dejó el estacionamiento: ')
    print('El costo a pagar es',ParkingBill(hora_entrada, hora_salida),'$')
    cadena_sample = lambda example_variable: hora_entrada, hora_salida
    best, others = big_o.big_o(ParkingBill, cadena_sample)
    print(best)