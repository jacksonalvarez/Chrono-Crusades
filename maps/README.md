# Maps Folder

This folder contains files related to map generation and map data.

## Structure

- **generated/**: Maps that are automatically generated during gameplay. These files are created dynamically and should not be manually edited.
- **templates/**: Predefined map layouts and templates used as a base for procedural generation.
- **map_generator.py**: Script for generating maps procedurally. This script defines how maps are created and can be modified to change map generation logic.

## Usage

- Use the **templates/** directory to store base layouts for maps.
- Modify **map_generator.py** to change or improve the procedural generation logic as needed.
- Automatically generated maps are stored in **generated/** and should be reviewed only if troubleshooting is needed.
