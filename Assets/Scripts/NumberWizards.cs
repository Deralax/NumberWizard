using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour {

	// Use this for initialization
	int max;
	int min;
	int guess;
	string inputtemp = "";
	
	void Start () {
		StartGame();
		
	}
	
	void StartGame () {
		max = 1;
		min = 0;
		guess = Random.Range(min, max);
		print ("==========================================");
		print ("Welcome to Number Wizard");
		print ("Start by entering the maximum number in your range.");
	}
	
	
	// Update is called once per frame
	void Update () {
	
		RangeSelect();
			
		if (Input.GetKeyDown(KeyCode.Equals)) {
			MaxSubmit();
		}
		if (Input.GetKeyDown(KeyCode.Minus)) {
			MinSubmit();
		}
		
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			//print ("Up arrow pressed.");
			min = guess;
			NextGuess();
		}else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			//print ("Down arrow pressed.");
			max = guess;
			NextGuess();
		}else if (Input.GetKeyDown(KeyCode.Return)) {
			print ("I won!");
			print ("Press P to play again!");
			 
		}
		if (Input.GetKeyDown(KeyCode.P)) {
			Start();
		}
		
	}
	
	void RangeSelect (){
		if (Input.GetKeyDown(KeyCode.Alpha0)){
			inputtemp = inputtemp + "0";
			SubmitMessage();
		}else if (Input.GetKeyDown(KeyCode.Alpha1)){
			inputtemp = inputtemp + "1";
			SubmitMessage();
		}else if (Input.GetKeyDown(KeyCode.Alpha2)){
			inputtemp = inputtemp + "2";
			SubmitMessage();
		}else if (Input.GetKeyDown(KeyCode.Alpha3)){
			inputtemp = inputtemp + "3";
			SubmitMessage();
		}else if (Input.GetKeyDown(KeyCode.Alpha4)){
			inputtemp = inputtemp + "4";
			SubmitMessage();
		}else if (Input.GetKeyDown(KeyCode.Alpha5)){
			inputtemp = inputtemp + "5";
			SubmitMessage();
		}else if (Input.GetKeyDown(KeyCode.Alpha6)){
			inputtemp = inputtemp + "6";
			SubmitMessage();
		}else if (Input.GetKeyDown(KeyCode.Alpha7)){
			inputtemp = inputtemp + "7";
			SubmitMessage();
		}else if (Input.GetKeyDown(KeyCode.Alpha8)){
			inputtemp = inputtemp + "8";
			SubmitMessage();
		}else if (Input.GetKeyDown(KeyCode.Alpha9)){
			inputtemp = inputtemp + "9";
			SubmitMessage();
		}
	}
	
	void MaxSubmit(){
		max = int.Parse(inputtemp) + 1;
		inputtemp = "";
		print ("You have selected " + (max - 1) + " as your maximum!");
		print ("Please enter the minimum number in the range!");
		RangeSelect();
	}
	
	void MinSubmit(){
		min = int.Parse(inputtemp);
		inputtemp = "";
		print ("You have selected " + min + " as your minimum!");
		print ("Pick a number in your head between " + min + " and " + (max - 1) + " but don't tell me!");
		guess = Random.Range(min, max);	
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up arrow = higher, down arrow = lower, return = equals.");
	}
	
	void SubmitMessage(){
		if (int.Parse(inputtemp) > max){
			print (inputtemp + "\t Press + to submit.");
		}else if (int.Parse(inputtemp) < max){
			print ("Choose a number less than " + (max - 1) + ".");
			print (inputtemp + "\t Press - to submit.");
		}
	}
	
	void NextGuess (){
		guess = Random.Range(min, max);
		print ("Higher or lower than " + guess + "?");
		print ("Up arrow = higher, down arrow = lower, return = equals.");
	}
}
