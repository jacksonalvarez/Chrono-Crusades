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


Description
assets/: Contains all media assets including audio files, sprites, icons, and fonts.

audio/: Directory for sound effects and background music.
sprites/: Contains subdirectories for various sprite types.
players/: Sprites for player characters.
enemies/: Sprites for enemy characters.
items/: Sprites for items in the game.
tilesets/: Tilesets used for creating maps.
icons/: Icons used in UI and other parts of the game.
fonts/: Fonts used in the game.
maps/: Contains map-related files.

generated/: Maps that are dynamically generated during gameplay.
templates/: Templates and layout definitions for maps.
map_generator.py: Script for procedural map generation.
scenes/: Scene files used in the game.

main_menu.tscn: Main menu scene.
gameplay.tscn: Scene for gameplay.
pause_menu.tscn: Scene for the pause menu.
game_over.tscn: Scene for game over screen.
src/: Source code for the game.

core/: Core game logic files.
game_controller.py: Manages overall game state.
entity_handler.py: Handles entities (players, enemies, items).
entities/: Definitions for various game entities.
player.py: Player class and logic.
enemy.py: Enemy class and logic.
item.py: Item class and logic.
systems/: Game systems for AI, inventory, and combat.
ai_system.py: AI logic for enemies.
inventory_system.py: Manages item inventories.
combat_system.py: Handles combat mechanics.
utilities/: Utility scripts and helpers.
math_utils.py: Mathematical utilities.
file_utils.py: File handling utilities.
config/: Configuration files.
game_settings.json: General game settings.
controls.json: Player control mappings.
scripts/: Additional scripts for map-related tasks and asset importing.

map_scripts.py: Scripts related to map generation and management.
asset_importer.py: Script for importing assets into the project.
docs/: Documentation for the project.

design.md: Design documents.
architecture.md: Architecture overview.
user_manual.md: User manual.
.gitignore: Specifies files and directories to be ignored by Git.

.gitattributes: Git attributes file.

README.md: Project overview and instructions.

project.godot: Godot project file.
