# Lanzar App Desde Otra App En MAUI.NET
Abrir app android desde otra app en MAUI

Crear una nueva Aplicacion Maui.

Una vez creada entrar al fichero Platforms y entrar al subfichero Android.
Crear una nueva clase parcial y crear dentro un metodo void parcial como se muestra.

![image](https://user-images.githubusercontent.com/44584844/178034375-6aa024ae-3252-488e-9d45-d22a89c7422e.png)

En el codigo new ComponentName("com.example.averesta", "com.example.averesta.MainActivity")
los parametros a pasar son el nombre del paquete y el nombre de la actividad. 
si tienes alguna duda puedes revisar el manifest de la app que deseas abrir.
Al momento de usar Android.App nos va a mostrar un error. este lo solucionamos eliminado la secion de Platforms.Android en el namespace

El siguiente paso es crear una nueva clase parcial dentro del directorio raiz. con el mismo nombre de la clase creada dentro del fichero Android.

![image](https://user-images.githubusercontent.com/44584844/178034718-157d4221-cdf5-428b-88a1-0d61b7da9371.png)

En el caso de obtener un error, en el menus desplegable de la esquina superior izquierda seleccionar el proyecto correcto y eso elimina el error
en este caso selecionar android.

![image](https://user-images.githubusercontent.com/44584844/178035376-a5c04821-8c38-4c56-a78d-5deafb558496.png)

una vez esto estamos listos para ocupar nuestro metodo desde el elemento requerido.
en este caso se usara con la plantilla por defecto de MAUI cambiando el codigo de muestra por el metodo a ejecutar.

![image](https://user-images.githubusercontent.com/44584844/178035703-a862fd40-8c45-4894-886c-8771eedb5643.png)

![2022_07_08_12_01_22](https://user-images.githubusercontent.com/44584844/178038338-9d06813d-1721-420e-b4dd-9e39850af7c2.gif)

Cabe resaltar que la APP MAUI abre una APP de Android studio.
