

 WHILE 1=1 
 BEGIN

     UPDATE Leg
     SET LegCurrentNumbersPlanes = (
     SELECT COUNT(*)
     FROM Flight
     WHERE NumberOfCurrentLeg = Leg.LegNumber
     );
 
     WAITFOR DELAY '00:00:10.000';
 END
