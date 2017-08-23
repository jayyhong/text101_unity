using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;

	private enum States {cell, mirror, sheets_0, sheets_0_think, lock_0, cell_mirror, sheets_1, lock_1, freedom, suicide};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update ()
	{
		print (myState);
		if (myState == States.cell) {
			state_cell ();
		}
		if (myState == States.sheets_0) {
			state_sheets_0 ();
		}
		if (myState == States.sheets_0_think) {
			state_sheets_0_think ();
		}
		if (myState == States.mirror) {
			state_mirror ();
		}
		if (myState == States.cell_mirror) {
			state_cell_mirror ();
		}
		if (myState == States.lock_0) {
			state_lock0 ();
		}
		if (myState == States.freedom) {
			state_freedom ();
		}
		if (myState == States.suicide) {
			state_suicide();
		}
	}

	void state_cell () {
		text.text = "You wake up to find yourself in a prison cell, you " +
					"have to escape before the ward touches your butt again." +
					"There are some dirty sheets on the bed, a mirror on the wall, "+
					"and the door is locked from the outside.\n\n" +
					"'S' to View Sheets \n" +
					"'M' to View Mirror\n" +
					"'L' to View Lock";
		if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.sheets_0;
		} else if (Input.GetKeyDown(KeyCode.M)) {
			myState = States.mirror;
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_0;
		}
	}

	void state_sheets_0 () {
		text.text = "These sheets haven't been washed in years. There are many " +
					"strange looking stains. An odor lingers from the dirty sheets.\n\n" + 
					"Press T to Think Aloud\n" +
					"Press R to Return to roaming";
		if (Input.GetKeyDown(KeyCode.T)){
			myState = States.sheets_0_think;
		}
		if (Input.GetKeyDown(KeyCode.R)){
			myState = States.cell;
		}
	}

	void state_sheets_0_think () {
		text.text = "These sheets haven't been washed in years. There are many " +
					"strange looking stains. An odor lingers from the dirty sheets.\n\n" + 
					"Press T to Think Aloud\n" + 
					"Press R to Return to roaming\n\n" + 
					"*Sniff sniff* Smells like a wet butthole.";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell;
		}
	}

	void state_mirror ()
	{
		text.text = "You're ugly.\n\n" +
		"Press R to go back\n" +
		"Press T to take the mirror";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		} else if (Input.GetKeyDown (KeyCode.T)) {
			myState = States.cell_mirror;
		}
	}

	void state_cell_mirror ()
	{
		text.text = "You break the mirror cause you're so ugly. Shards scatter across the floor.\n\n" +
		"Press K to kill yourself\n" +
		"Press F for Freedom";
		if (Input.GetKeyDown (KeyCode.K)) {
			myState = States.suicide;
		} else if (Input.GetKeyDown (KeyCode.F)) {
			myState = States.freedom;
		}
	}

	void state_lock0 ()
	{
		text.text = "It's locked. You wish you can get out. Sucker.\n\n" +
		"Press R to Return";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		}
	}

	void state_freedom() {
		text.text = "You shank the prison door with a broken shard.. The door gets sliced in half... " +
				"A man with a familiar face stares at you from the end of the hallway...\n\n" +
				"Press T to Touch his butt\n" +
				"Press K to Kill him.";
	}

	void state_suicide ()
	{
		text.text = "You grab a broken shard, and stab yourself. You think about all the times " +
		"the warden touched your butt. The light slowly fades away...\n\n" +
		"Press R to come back to life";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell_mirror;
		}
	}

}
