# Chrono Crusaders Documentation

Welcome to the Chrono Crusaders project documentation. This guide provides an overview of the project's structure, codebase, and assets to help you navigate and contribute effectively.

## Table of Contents

1. [Introduction](#introduction)
2. [Project Structure](#project-structure)
3. [Assets](#assets)
4. [Codebase](#codebase)
5. [Documentation](#documentation)
6. [Contributing](#contributing)
7. [License](#license)

---

## Introduction

Welcome to the Chrono Crusaders project! This section provides an overview of the game and its goals.

[Back to Table of Contents](#table-of-contents)

---

## Project Structure

Here’s an overview of the project's directory structure:

```plaintext
ChronoCrusaders/
├── assets/
│   ├── audio/
│   ├── sprites/
│   │   ├── players/
│   │   ├── enemies/
│   │   ├── items/
│   │   └── tilesets/
│   ├── icons/
│   └── fonts/
## Assets

**`assets/`**: Contains all media assets used in the game.

- **`audio/`**: Contains sound effects and background music files.
  - **Files**: Typically `.wav`, `.mp3`

- **`sprites/`**: All sprite images, organized into subdirectories:
  - **`players/`**: Sprites for player characters.
  - **`enemies/`**: Sprites for enemy characters.
  - **`items/`**: Sprites for items.
  - **`tilesets/`**: Tilesets used for creating maps.

- **`icons/`**: Icons used in UI and other parts of the game.

- **`fonts/`**: Fonts used throughout the game.


├── maps/
│   ├── generated/
│   ├── templates/
│   └── map_generator.py
├── scenes/
│   ├── main_menu.tscn
│   ├── gameplay.tscn
│   ├── pause_menu.tscn
│   └── game_over.tscn
├── src/
│   ├── core/
│   │   ├── game_controller.py
│   │   └── entity_handler.py
│   ├── entities/
│   │   ├── player.py
│   │   ├── enemy.py
│   │   └── item.py
│   ├── systems/
│   │   ├── ai_system.py
│   │   ├── inventory_system.py
│   │   └── combat_system.py
│   ├── utilities/
│   │   ├── math_utils.py
│   │   └── file_utils.py
│   └── config/
│       ├── game_settings.json
│       └── controls.json
├── scripts/
│   ├── map_scripts.py
│   └── asset_importer.py
├── docs/
│   ├── design.md
│   ├── architecture.md
│   └── user_manual.md
├── .gitignore
├── .gitattributes
├── README.md
└── project.godot



