using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class ExampleExperiment : Experiment
{

	public GUIRate guiRate;
	public GameObject start;
	public GameObject target1;
	public GameObject target2;

	public override void initValues ()
	{
		name = "Balloon Experiment";
		input = "input.txt";
	}

	public override void init ()
	{
		status = "Wellcome";
		instruction = "Wellcome! You wanna learn how hot air balloons navigate?\n Then please press <space> to begin!";
		target1.SetActive (false);
		target2.SetActive (false);

		phases.Add (new ExperimentPhase (5, ()=>{
			status = "";
			instruction = "Hot air balloon navigate by turning a hot source under the balloon on and off.";
		}));

		phases.Add (new ExperimentPhase (5, ()=>{
			instruction = "Turning a hot source like fire on will make the balloon rise.\nTurning it off will make it lower.";
		}));

		phases.Add (new ExperimentPhase (1, ()=>{
			isBlackout = false;
			subject.representation.transform.position = start.transform.position;
			instruction = "";
		}));

		phases.Add (new ExperimentPhase (2, ()=>{
			instruction = "This is our playground!";
		}));

		phases.Add (new ExperimentPhase (5, ()=>{
			instruction = "You can control this balloon by pressing <space> to turn the fire on and releasing <space> to turn it off.";
		}));

		phases.Add (new ExperimentPhase (3, ()=>{
			instruction = "Let's go! Try it out!";
		}));

		phases.Add (new ExperimentPhase (3, ()=>{
			instruction = "Press and release <space> to control the flame";
			subject.representation.GetComponent<Movement> ().canMove = true;
		}));

		phases.Add (new ExperimentPhase (8, ()=>{
			instruction = "";
		}));

		phases.Add (new ExperimentPhase (5, ()=>{
			isBlackout = true;
			instruction = "The balloons will be pushed in different directions on different heights.";
			subject.representation.GetComponent<Movement> ().canMove = false;
		}));

		phases.Add (new ExperimentPhase (7, ()=>{
			instruction = "This is caused by the different wind directions and it's the way hot air balloons navigate.";
		}));

		phases.Add (new ExperimentPhase (4, ()=>{
			instruction = "Now you know how hot air balloons navigate!";
		}));

		phases.Add (new ExperimentPhase (1, ()=>{
			subject.representation.transform.position = start.transform.position;
			isBlackout = false;
			instruction = "";
		}));

		phases.Add (new ExperimentPhase (5, ()=>{
			instruction = "Try and navigate to the red spot!";
			subject.representation.GetComponent<Movement> ().canMove = true;
			target1.SetActive (true);
		}));
			
		phases.Add (new ExperimentPhase (1, ()=>{
			instruction = "";
			pause = true;
		}));

		phases.Add (new ExperimentPhase (3, ()=>{
			instruction = "You made it!";
			target1.SetActive (false);
		}));
			
		phases.Add (new ExperimentPhase (1, ()=>{
			instruction = "";
			target2.SetActive (true);
		}));

		phases.Add (new ExperimentPhase (5, ()=>{
			instruction = "Now try and navigate to the green spot!";
		}));

		phases.Add (new ExperimentPhase (1, ()=>{
			instruction = "";
			pause = true;
		}));

		phases.Add (new ExperimentPhase (3, ()=>{
			instruction = "Perfect!";
		}));

		phases.Add (new ExperimentPhase (5, ()=>{
			instruction = "Well done and thank you for your patience!\nWe hope you liked this experiment!";
		}));
	}
}
