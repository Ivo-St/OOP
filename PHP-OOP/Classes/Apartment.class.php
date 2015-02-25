<?php

namespace Classes;

class Apartment extends Room{
    public function __construct($number,$price){
        parent::__construct($number,$price,4,RoomType::Diamond,true,true,["TV","air-conditioner","refrigerator",
            "mini-bar","bathtub","kitchen-box","free Wi-Fi"],[]);
    }
}