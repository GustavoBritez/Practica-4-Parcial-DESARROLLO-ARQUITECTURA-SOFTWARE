# Practica-4-Parcial-DESARROLLO-ARQUITECTURA-SOFTWARE

Armar BD de equipos informáticos que compra una empresa a proveedores.Pasa las columnas y tipos de la tabla. 

El primer dgv hacer que mostré la tabla en un orden diferente y agregar dos  datos mas

Visualización en Grilla Principal

Código
Año de Compra
Valor residual (Valor actual  del equipo , calculado restando un 15% por cada año transcurrido entre el año actual y el año de compra, sin que el valor  sea negativo. Esto no es un campo en la base de datos)
En uso
Valor de la compra
Fecha Ingreso
Fecha Baja
Cantidad de días en la empresa (Diferencia entre la fecha de ingreso y la fecha de baja, o entre la fecha de ingreso y la fecha actual si el equipo sigue en uso)

Si un equipo aún sigue en la empresa y no tiene una fecha de baja , se debe colocar fecha de baja por defecto 01/01/2999.


El código de equipo debe respetar el formato:
EQ-2025-001 (El prefijo EQ-, seguido de cuatro dígitos del año y tres dígitos relativos)
No deben permitir códigos duplicados
No se puede modificar una vez ingresado
