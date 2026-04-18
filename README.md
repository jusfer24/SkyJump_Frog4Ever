# SkyJump_Frog4Ever 🐸

![Unity](https://img.shields.io/badge/Unity-2022.3+-black?style=for-the-badge&logo=unity)
**_**
![C#](https://img.shields.io/badge/C%23-Scripting-blue?style=for-the-badge&logo=csharp)
**_**
![Platform](https://img.shields.io/badge/Platform-WebGL%20%7C%20PC-orange?style=for-the-badge&logo=googlechrome)

**Frog4Ever** es un juego de plataformas horizontal con una proyeccion de chunks infinitos y un estilo arcade donde se pueda implementar multiplayer desarrollado en Unity. El objetivo es simple pero desafiante: salta lo más alto posible mientras esquivas obstáculos dinámicos, mientras que el terreno se genera de forma pseudo-infinita, asegurando que cada partida sea única.

---

## 🛠️ Características Técnicas

Este proyecto implementa patrones de diseño y técnicas de optimización esenciales para el desarrollo de videojuegos:

* **Generación Procedimental por Chunks:** El mapa se construye dinámicamente utilizando secciones pre-diseñadas (chunks) que se instancian y destruyen según la posición del jugador para optimizar el uso de memoria.
* **Sistema de Object Pooling:** Implementación de una reserva de objetos para los obstáculos dinámicos, evitando el uso excesivo de `Instantiate` y `Destroy`, lo que elimina picos de lag y optimiza el Garbage Collector.
* **Cámara con Seguimiento Vertical:** Controlador de cámara personalizado que sigue al jugador exclusivamente en el eje vertical (Y) con un efecto de suavizado (*Lerp*) y restricciones para mantener la perspectiva estática en X.
* **Interfaz Adaptativa (Responsive):** UI configurada con *Canvas Scaler* y *Anchors* para garantizar una visualización correcta en resoluciones 16:9 y diferentes tamaños de ventana en itch.io.

---

## 🎮 Gameplay

* **Objetivo:** Ascender por las plataformas y obtener la puntuación más alta basada en la altitud alcanzada.
* **Obstáculos:** Esquiva las trampas dinámicas que caen desde la parte superior de la pantalla.
* **Game Over:** El juego termina si el jugador colisiona con un obstáculo o cae fuera del límite inferior de la cámara.

---

## 🚀 Instalación y Ejecución

1.  Clona este repositorio.
2.  Abre el proyecto con **Unity 2022.3 LTS** o superior.
3.  Abre la escena principal en `Assets/Scenes/MainScene.unity`.
4.  Presiona **Play** en el editor o exporta para **WebGL** desde `Build Settings`.

---

## 📂 Estructura del Proyecto

* `/Scripts`: Lógica del jugador, controladores de cámara, generador de niveles y sistemas de pooling.
* `/Prefabs`: Chunks de nivel, plataformas y obstáculos configurados.
* `/Sprites`: Arte y elementos visuales del entorno arcade.
* `/Animations`: Controladores y clips de animación para estados de victoria y movimiento.

---

## 📝 Roadmap de Desarrollo

- [x] Sistema de pooling para obstáculos dinámicos.
- [x] Cámara con seguimiento vertical suavizado.
- [x] UI responsive para 16:9.
- [ ] Generador de terreno infinito por chunks.
- [ ] Implementar tabla de puntuaciones locales (Highscores).
- [ ] Añadir efectos de partículas y feedback visual (Juice).
- [ ] Integración de efectos de sonido y música arcade.

---

## 🎮 Donde Jugar?
* **Itch.io:** [jusfer24/frog4ever](https://jusfer24.itch.io/frog4ever)

---
