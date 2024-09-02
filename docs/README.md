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

**ChronoCrusaders/**
- **assets/**  
  - **audio/**  
  - **sprites/**  
    - **players/**  
    - **enemies/**  
    - **items/**  
    - **tilesets/**  
  - **icons/**  
  - **fonts/**  

- **maps/**  
  - **generated/**  
  - **templates/**  
  - **map_generator.py**  

- **scenes/**  
  - **main_menu.tscn**  
  - **gameplay.tscn**  
  - **pause_menu.tscn**  
  - **game_over.tscn**  

- **src/**  
  - **core/**  
    - **game_controller.py**  
    - **entity_handler.py**  
  - **entities/**  
    - **player.py**  
    - **enemy.py**  
    - **item.py**  
  - **systems/**  
    - **ai_system.py**  
    - **inventory_system.py**  
    - **combat_system.py**  
  - **utilities/**  
    - **math_utils.py**  
    - **file_utils.py**  
  - **config/**  
    - **game_settings.json**  
    - **controls.json**  

- **scripts/**  
  - **map_scripts.py**  
  - **asset_importer.py**  

- **docs/**  
  - **design.md**  
  - **architecture.md**  
  - **user_manual.md**  

- **.gitignore**  
- **.gitattributes**  
- **README.md**  
- **project.godot**
