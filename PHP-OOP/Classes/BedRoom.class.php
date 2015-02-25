<?php

namespace Classes;

class BedRoom extends Room{
    public function __construct($number,$price){
        parent::__construct($number,$price,2,RoomType::Gold,true,true,["TV","air-conditioner","refrigerator"
            ,"mini-bar","bathtub"],[]);
    }
}