<?php

namespace Classes;

class Reservation {
    const DateFormat = "d.m.Y";
    private $startDate;
    private $endDate;
    private $guest;

    public function __construct($startDate,$endDate,$guest){
        $this->setStartDate($startDate);
        $this->setEndDate($endDate);
        $this->setGuest($guest);
    }

    public function getStartDate(){
        return $this->startDate;
    }

    public function setStartDate($startDate){
        $this->startDate=$startDate;
    }

    public function getEndDate(){
        return $this->endDate;
    }

    public function setEndDate($endDate){
        $this->endDate=$endDate;
    }

    public function getGuest(){
        return $this->guest;
    }

    public function setGuest($guest){
        $this->guest=$guest;
    }

    public function __toString(){
        $result = "Reservation from: "
            . date(self::DateFormat,$this->getStartDate())
            . " to "
            . date(self::DateFormat,$this->getEndDate())
            . " Guest: "
            . $this->getGuest();

        return $result;
    }
}