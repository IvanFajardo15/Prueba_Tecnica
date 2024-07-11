Buen día,

Algunas recomendaciones si se quiere ejecutar en local:

- La aplicación se realizó en el IDE Visual Studio 2022.
- Se deben tener instaladas las dependencias de Selenium webdriver, Selenium Support, Nuit y Nunit3TestAdapter.
- Las dependencias anteriores vienen incluídas en el proyecto pero no esta demás verificar su correcta instalación.
- El proyecto se divide en 2 aplicaciones de consola, la principal (Prueba_Tecnica) contiene el modelado de objetos y métodos y la aplicación (Test) contiene El framework para la ejecución.
- Para realizar la ejecución se recomienda abrir el archivo UnitTest1.cs dentro de la aplicación "Test" y luego en el menu superior seguir la ruta Prueba -> Explorador de pruebas.
- Una vez abierto el explorador de pruebas se puede ejecutar pulsando la opción "Ejecutar todas las pruebas de la vista" y allí mismo se muestra el resultado de las pruebas (tiempo de ejecución, resultados exitosos/fallidos).
