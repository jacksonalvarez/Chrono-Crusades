extends CharacterBody2D

@export var speed := 500
#This value is a joke / so I could tell that sprint was actually working
@export var sprint_diff := 1000
#These two can be any type of node we decide fits best for items when we make those scenes
@export var items: Array[Node2D] = []
@export var active_item: Array[Node2D] = []

func _ready() -> void:
	position = Vector2(960, 540)

func _process(_delta: float) -> void:
	#This top line determines input based on a custom input map
	var dir = Input.get_vector("Left", "Right", "Up", "Down")
	if Input.is_action_pressed("Sprint"):
		velocity = dir * (speed + sprint_diff)
	else:
		velocity = dir * speed
	#The beauty
	move_and_slide()
