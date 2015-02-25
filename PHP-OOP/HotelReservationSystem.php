<?php
function __autoload($className)
{
    $path = "./$className" . ".class.php";
    include_once($path);
}

function compareToPrice($element,$price = 250){
    return $element->getPrice() <=$price;
}

function hasBalcony($element){
    return $element->getHasBalcony();
}

use Classes\SingleRoom;
use Classes\BedRoom;
use Classes\Apartment;
use Classes\Reservation;
use Classes\Guest;
use Classes\BookingManager;

$room = new SingleRoom(1408, 99);

$bedroom1 = new BedRoom(101,130);
$bedroom2 = new BedRoom(102,230);
$bedroom3 = new BedRoom(103,335);

$apartment1 = new Apartment(201,160);
$apartment2 = new Apartment(202,250);
$apartment3 = new Apartment(202,270);

$roomArray = [$bedroom1,$bedroom2,$bedroom3,$apartment1,$apartment2,$apartment3,$room];

$guest = new Guest("Test", "Person", 8003224277);
$guest1 = new Guest("Test1","Person1",8006123145);
$guest2 = new Guest("Test2","Person2",8010229245);
$guest3 = new Guest("Test3","Person3",9000531628);
$guest4 = new Guest("Test4","Person4",7406123445);
$guest5 = new Guest("Test5","Person5",6906221265);

$startDate = strtotime("24.10.2014");
$endDate = strtotime("26.10.2014");
$startDate1 = strtotime("22.12.2014");
$endDate1 = strtotime("26.01.2015");
$startDate2 = strtotime("25.06.2014");
$endDate2 = strtotime("26.06.2014");
$startDate3 = strtotime("26.10.2014");
$endDate3 = strtotime("27.10.2014");
$startDate1 = strtotime("22.11.2014");
$endDate3 = strtotime("27.12.2014");
$startDate4 = strtotime("25.06.2014");
$endDate4 = strtotime("27.12.2014");

$reservation = new Reservation($startDate, $endDate, $guest);
$reservation1 = new Reservation($startDate1, $endDate1, $guest1);
$reservation2 = new Reservation($startDate2, $endDate2, $guest2);
$reservation3 = new Reservation($startDate3, $endDate3, $guest3);
$reservation4 = new Reservation($startDate4, $endDate4, $guest4);
$reservation5 = new Reservation($startDate4, $endDate4, $guest5);

BookingManager::bookRoom($bedroom1, $reservation);
BookingManager::bookRoom($bedroom2, $reservation1);
BookingManager::bookRoom($bedroom3, $reservation2);
BookingManager::bookRoom($apartment1, $reservation3);
BookingManager::bookRoom($apartment2, $reservation4);
BookingManager::bookRoom($apartment3, $reservation5);

echo "<br/><strong>Sorted by price</strong><br/>";

$sorted = array_filter($roomArray,"compareToPrice");

foreach($sorted as $value){
    echo $value;
    echo "<br/>";
}

echo "<br/><strong>Sorted by hasBalcony</strong><br/>";

$sorted = array_filter($roomArray,"hasBalcony");

foreach($sorted as $value){
    echo $value;
    echo "<br/>";
}

?>