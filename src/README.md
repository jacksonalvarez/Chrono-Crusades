# Source Code Folder

This folder contains all the source code for the game. There are different environments for different phases of launch/version release.

## Release Stages

| **Stage**       | **Description**                                                                                  |
|-----------------|--------------------------------------------------------------------------------------------------|
| **DEV**         | Development stage where new features and major changes are actively worked on and tested internally. |
| **ALPHA**       | Initial testing phase where the game is feature-complete but still undergoing internal testing for bugs and stability. |
| **BETA**        | Public testing phase where a wider audience is invited to test the game. Feedback is gathered to identify and fix issues before the final release. |
| **USER-TEST**   | Focused testing phase where specific aspects of the game are tested by targeted user groups to refine features and usability. |
| **Final-DEV**   | Final development stage where the game is polished, bugs are fixed, and preparation for release is completed. |
| **Release**     | Official release of the game to the public. The game is considered stable and ready for general use. |
| **Updates**     | Post-release phase where ongoing support, patches, and new features are introduced based on user feedback and emerging issues. |

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
  ###### -  tools that we build outside of the other categories get dropped in here or utilities usually.

- **utilities/**: Helper scripts and utility functions.
    - make, outside technologies.

- **config/**: Configuration files for the game.
  - **game_settings.json**: General settings for the game.
  - **controls.json**: Player control mappings.

## Usage

- Organize code by functionality and keep related classes and scripts together.
- Follow coding standards and naming conventions for consistency.
- Update and maintain documentation within this folder as changes are made.
