# Chrono Crusaders

Welcome to the Chrono Crusaders project! This is a 2D roguelike game featuring procedurally generated maps, dynamic combat, and a variety of entities.

## Project Structure

ChronoCrusaders/
├── assets/                  # All media assets
│   ├── audio/               # Sound effects and background music
│   ├── sprites/             # All sprite images
│   │   ├── players/         # Player sprites
│   │   ├── enemies/         # Enemy sprites
│   │   ├── items/           # Item sprites
│   │   └── tilesets/        # Tilesets for maps
│   ├── icons/               # Icons for UI and other elements
│   └── fonts/               # Fonts used in the game
├── maps/                   # Map data and generators
│   ├── generated/          # Maps generated during gameplay
│   ├── templates/          # Map templates and layout definitions
│   └── map_generator.py     # Scripts for procedural map generation
├── scenes/                 # Scene files
│   ├── main_menu.tscn      # Main menu scene
│   ├── gameplay.tscn       # Gameplay scene
│   ├── pause_menu.tscn     # Pause menu scene
│   └── game_over.tscn      # Game over scene
├── src/                    # Source code
│   ├── core/               # Core game logic
│   │   ├── game_controller.py  # Manages the overall game state
│   │   └── entity_handler.py   # Manages entities (players, enemies, items)
│   ├── entities/           # Entity definitions
│   │   ├── player.py       # Player class and related logic
│   │   ├── enemy.py        # Enemy class and related logic
│   │   └── item.py         # Item class and related logic
│   ├── systems/            # Game systems
│   │   ├── ai_system.py    # AI logic for enemies
│   │   ├── inventory_system.py  # Item inventory management
│   │   └── combat_system.py      # Combat logic
│   ├── utilities/          # Utility scripts and helpers
│   │   ├── math_utils.py   # Mathematical utilities
│   │   └── file_utils.py   # File handling utilities
│   └── config/             # Configuration files
│       ├── game_settings.json  # General game settings
│       └── controls.json       # Player control mappings
├── scripts/                # Additional scripts
│   ├── map_scripts.py       # Scripts for map-related tasks
│   └── asset_importer.py    # Script for importing assets
├── docs/                   # Documentation
│   ├── design.md           # Design documents
│   ├── architecture.md     # Architecture overview
│   └── user_manual.md      # User manual
├── .gitignore              # Git ignore file
├── .gitattributes          # Git attributes file
├── README.md               # Project overview and instructions
└── project.godot           # Godot project file


## Getting Started

1. **Setup**: Ensure you have all dependencies installed and configure your development environment.
2. **Running the Game**: Follow the instructions in `docs/user_manual.md` to run and test the game.
3. **Contributing**: For contributing guidelines, refer to the documentation in `docs/design.md` and `docs/architecture.md`.

## Contribution

Feel free to contribute to the project! Please make sure to follow the coding standards and update relevant documentation as needed.

