# Cauciones
Permite calcular cauciones en el mercado bursatil, a continuación explico los diferentes campos y que hace cada uno:
Inversion Inicia: Ingresar el monto de la inversión inicial que se quiere colocar en caucion (Obligatorio)
Tasa Inicia %: Cual es la tasa en la que colocamos la caución (Obligatorio)
Tasa Final%: Nos permite observar que ocurre con nuestra inversión si antes del plazo de fin de inversión cambia la tasa. Si ingresamos un valor aqui el valor de la tasa ira cambiando a proporcionalmente a medida
que nos acerquemos al plazo final de inversión. Si no se ingresa ningun valor el valor de la tasa inicial es el que se calcula para todo el periodo de inversión (Optativo)
Comision Broker: Acá ponemos la comisión que nos cobra el broker (se puede sumar tambien los derechos de mercado para que sea mas realista) sobre la caución que colocamos (Obligatorio)
Plazo caución: Indicar a cuantos días es la caución si a un día, cinco, doce, quince, etc. En caso de no poner nada por defecto toma la caucíon a un dia (Optativo)
Fecha Final Inversion: Indica por cuanto tiempo pensamos ir renovando la caución. Así si alguien quiere renovar cauciones semanalmente, por tres meses, selecciona en el calendario tres meses en el futuro. (Por defecto esta seteado a dos días vista)
Periodo Agrupación: Nos permite observar como evoluciona la caución agrupándola en diferentes periodos. Por ej si la fecha final de inversion es a un año y elegimos la caución a un día, tal vez mas que ver el movimiento de mas de 250 cauciones nos
interese ver su evolución mes a mes. (Por defecto esta seteado en diario)

Nota: Internamente en caso de elegir un plazo de caución a un día al calcular la caución del dia viernes, calcula tambien la caución del fin de semana (Osea la caución del viernes, sabado y domingo)
Nota 2: En caso que el periodo de agrupación sea menor o igual al plazo del plazo de caución la fecha mostrada en la tabla será la del inicio de la caución. En caso de ser superior mostra la fecha de inicio de la ultima caución del periodo.
(Obviamente los montos de inversion acumulada e intereses pagados finales son los mismos, simplemente cambia la forma en que se agrupan)




