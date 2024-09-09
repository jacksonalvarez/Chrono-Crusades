extends Sprite2D

@onready var parent: Node2D = $".."

var pressing := false
var i = 0

@export var max_length := 150
@export var dead_zone := 5

# Called when the node enters the scene tree for the first time.
func _ready() -> void:
	max_length *= parent.scale.x


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta: float) -> void:
	if pressing:
		if get_global_mouse_position().distance_to(parent.global_position) <= max_length:
			global_position = get_global_mouse_position()
		else:
			var angle = parent.global_position.angle_to_point(get_global_mouse_position())
			global_position.x = parent.global_position.x + cos(angle) * max_length
			global_position.y = parent.global_position.y + sin(angle) * max_length
		calculateVec()
	else:
		global_position = lerp(global_position, parent.global_position, delta * 10)
		parent.posVec = Vector2(0, 0)

func calculateVec():
	if abs(global_position.x - parent.global_position.x) >= dead_zone:
		parent.posVec.x = (global_position.x - parent.global_position.x) / max_length
	if abs(global_position.y - parent.global_position.y) >= dead_zone:
		parent.posVec.y = (global_position.y - parent.global_position.y) / max_length

func _on_button_button_down() -> void:
	pressing = true
	parent.global_position = get_global_mouse_position()


func _on_button_button_up() -> void:
	pressing = false
