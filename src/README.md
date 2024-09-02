# Source Code Folder

This folder contains all the source code for the game.

## Structure

- **core/**: Contains core game logic and main controllers.
  - **game_controller.py**: Manages the overall game state, including starting and ending the game.
  - **entity_handler.py**: Manages game entities like players, enemies, and items.
- **entities/**: Contains definitions and logic for game entities.
  - **player.py**: Player character class and related logic.
  - **enemy.py**: Enemy character class and related logic.
  - **item.py**: Item class and related logic.
- **systems/**: Contains various systems and game mechanics.
  - **ai_system.py**: Logic for enemy AI.
  - **inventory_system.py**: Manages player inventory.
  - **combat_system.py**: Handles combat interactions.
- **utilities/**: Helper scripts and utility functions.
  - **math_utils.py**: Mathematical utilities.
  - **file_utils.py**: Utilities for file handling.
- **config/**: Configuration files for the game.
  - **game_settings.json**: General settings for the game.
  - **controls.json**: Player control mappings.

## Usage

- Organize code by functionality and keep related classes and scripts together.
- Follow coding standards and naming conventions for consistency.
- Update and maintain documentation within this folder as changes are made.
