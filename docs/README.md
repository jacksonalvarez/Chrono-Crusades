# Chrono Crusaders Documentation

Welcome to the Chrono Crusaders documentation. This documentation is divided into several sections to help you navigate through the details of the project.

## Table of Contents

1. [Introduction](#1-introduction)
2. [Project Structure](#2-project-structure)
3. [Assets](#3-assets)
4. [Codebase](#4-codebase)
5. [Documentation](#5-documentation)
6. [Contributing](#6-contributing)
7. [License](#7-license)

---

## 1. Introduction

Welcome to the Chrono Crusaders project! This section provides an overview of the game and its goals.

[Back to Table of Contents](#table-of-contents)

---

## 2. Project Structure

Here’s an overview of the project’s directory structure:

| Directory/File      | Description                               |
|---------------------|-------------------------------------------|
| **assets/**         | All media assets                          |
| ├── audio/          | Sound effects and background music        |
| ├── sprites/        | All sprite images                         |
| │   ├── players/    | Player sprites                             |
| │   ├── enemies/    | Enemy sprites                              |
| │   ├── items/      | Item sprites                               |
| │   └── tilesets/   | Tilesets for maps                          |
| ├── icons/          | Icons for UI and other elements            |
| └── fonts/          | Fonts used in the game                     |
| **maps/**           | Map data and generators                    |
| ├── generated/      | Maps generated during gameplay             |
| ├── templates/      | Map templates and layout definitions       |
| └── map_generator.py| Scripts for procedural map generation      |
| **scenes/**         | Scene files                                |
| ├── main_menu.tscn  | Main menu scene                            |
| ├── gameplay.tscn   | Gameplay scene                             |
| ├── pause_menu.tscn | Pause menu scene                           |
| └── game_over.tscn  | Game over scene                            |
| **src/**            | Source code                                |
| ├── core/           | Core game logic                            |
| │   ├── game_controller.py | Manages the overall game state       |
| │   └── entity_handler.py  | Manages entities (players, enemies, items)|
| ├── entities/       | Entity definitions                         |
| │   ├── player.py   | Player class and related logic             |
| │   ├── enemy.py    | Enemy class and related logic              |
| │   └── item.py     | Item class and related logic               |
| ├── systems/        | Game systems                               |
| │   ├── ai_system.py| AI logic for enemies                       |
| │   ├── inventory_system.py | Item inventory management            |
| │   └── combat_system.py   | Combat logic                           |
| ├── utilities/      | Utility scripts and helpers               |
| │   ├── math_utils.py   | Mathematical utilities                  |
| │   └── file_utils.py   | File handling utilities                  |
| └── config/         | Configuration files                        |
|     ├── game_settings.json | General game settings                |
|     └── controls.json    | Player control mappings                 |
| **scripts/**        | Additional scripts                         |
| ├── map_scripts.py  | Scripts for map-related tasks              |
| └── asset_importer.py | Script for importing assets               |
| **docs/**           | Documentation                               |
| ├── design.md       | Design documents                           |
| ├── architecture.md | Architecture overview                     |
| └── user_manual.md  | User manual                                |
| **.gitignore**      | Git ignore file                            |
| **.gitattributes**  | Git attributes file                        |
| **README.md**       | Project overview and instructions          |
| **project.godot**   | Godot project file                         |
