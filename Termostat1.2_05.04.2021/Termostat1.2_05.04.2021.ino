
#include <SFE_BMP180.h>
#include <Wire.h>
#define ledPin 6
SFE_BMP180 tmp;
typedef unsigned char U8;
U8 setPoint = 26;
U8 a[6];
U8 b[6];
U8 i;

/*##############################################################################################*/
// Function for detecting the temperature

U8 ReadTemp()  {
  U8 status;
  double T;

  status = tmp.startTemperature();

  if (status != 0)
  {
    // Waiting for the measurement to be completed
    delay(status);
    //Measurement saved in T
    // Function returns 1 if successful and 0 if failure.

    status = tmp.getTemperature(T);
    if (status != 0)
    {
      //If status is different from 0 function returns temperature through T
      //Serial.print(" deg C, "); IF needed

      return T;
    }

  }

}


/*##############################################################################################*/
//Void function used for switching On/Off the light using a boolean var.

void setVoltage( bool state ) {
  digitalWrite(ledPin, state);
  //INVERTED VALUES- setVoltage(0) = 1,setVoltage(1) = 0;
}


U8 heatingStatus(U8 readtemp, U8 setPoint)
{
  U8 Hyst = 2;
  if (readtemp < setPoint - Hyst)
  {
    return 11; //10 = off, 11=on
  }

  if ((readtemp < setPoint + Hyst) && (readtemp > setPoint - Hyst))
  {
    if ((readtemp > setPoint - Hyst) && (readtemp < setPoint))
    {
      return 11;
    }
    else
    {
      return 10;
    }
  }
  if (readtemp > setPoint + Hyst)
  {
    return 10;
  }

  if (readtemp > 70) return 10;

}

void heatingSystem(U8 readtemp, U8 setPoint)
{
  U8 Hyst = 2;
  if (readtemp < setPoint - Hyst)
  {
    setVoltage (0);
  }

  if ((readtemp < setPoint + Hyst) && (readtemp > setPoint - Hyst))
  {
    if ((readtemp > setPoint - Hyst) && (readtemp < setPoint))
    {
      setVoltage(0);
    }
    else
    {
      setVoltage(1);
    }
  }
  if (readtemp > setPoint + Hyst)
  {
    setVoltage(1);
  }

  if (readtemp > 70) setVoltage(1);
} 

//U8 setSetPoint(U8 receiveVal, U8 setPoint) 
//{
//  if(receiveVal == 3) 
//  {
//    setPoint++; 
//    return setPoint;
//  }  
//  else if(receiveVal == 4) 
//  {
//    setPoint--; 
//    return setPoint;
//  } 
//  else return setPoint;
//}



/*##############################################################################################*/
void setup() {


  pinMode(ledPin, OUTPUT);
  Serial.begin(115200);
  Serial.println("REBOOT");


  // Sensor initialization
  if (tmp.begin())
    Serial.println("Sensor: ON");
  else
  {

    Serial.println("Sensor: OFF");
    while (1); //  Program stops
  }


}

/*##############################################################################################*/
void loop() {
  U8 readtemp = ReadTemp();
  U8 receiveVal;

heatingSystem(readtemp, setPoint);
 //receiveVal = Serial.read();
 //setPoint = setSetPoint(receiveVal, setPoint); 
 //if(receiveVal == '3')  
 //{
  //setPoint++; 
 //} 
 //else if(receiveVal == '4')
 //{
  //setPoint--;
 //} 
 //Serial. println(setPoint);

 

  a[0] = 0xFE;
  a[1] = readtemp;
  //a[2] = setSetPoint(receiveVal,setPoint); 
  a[2] = setPoint;
  a[3] = heatingStatus(readtemp, setPoint);
  a[4] = a[1] + a[2] + a[3];
  a[5] = 0xFF;

  for (i = 0; i < 6; i++)
  {
    b[i] = a[i]; 
  }
  Serial.write(b,6);

delay(500);
 


}
