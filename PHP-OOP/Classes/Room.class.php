<?php
namespace Classes;

class Room implements IReservable{
	private $roomNumber;
	private $hasBathroom;
	private $hasBalcony;
	private $price;
	private $numberOfBeds;
	private  $extras;
	private  $reservations;
	private $roomType;
	
	public function __construct($number,$price,$numberOfBeds,$roomType=RoomType::Standart,$hasBathroom=false,$hasBalcony=false,$extras=[],$reservations=[]){
		$this->setRoomNumber($number);
		$this->setPrice($price);
		$this->setNumberOfBeds($numberOfBeds);
		$this->setHasBathroom($hasBathroom);
		$this->setHasBalcony($hasBalcony);
		$this->setExtras($extras);
		$this->setReservations($reservations);
		$this->setRoomType($roomType);
	}

	public function getRoomType(){
		return $this->roomType;
	}

	public function setRoomType($roomTye){
		if($roomTye==RoomType::Diamond || $roomTye==RoomType::Gold || $roomTye==RoomType::Standart){
			$this->roomType=$roomTye;
			return;
		}

		echo "There is no room type of this kind";
	}

	public function getRoomNumber(){
		return $this->roomNumber;
	}
	
	public function setRoomNumber($number){
		if($number<0){
			echo "Room number cannot be negative value";
			return;
		}
		
		$this->roomNumber=$number;
	}

	public function getHasBathroom(){
		return $this->hasBathroom;
	}

	public function setHasBathroom($bathroom){
		$this->hasBathroom=$bathroom;
	}

	public  function  getHasBalcony(){
		return $this->hasBalcony;
	}

	public  function  setHasBalcony($balcony){
		$this->hasBalcony=$balcony;
	}

	public  function getPrice(){
		return $this->price;
	}

	public  function  setPrice($price){
		if($price<0){
			echo "Price cannot be negative value";
			return;
		}

		$this->price=$price;
	}

	public  function  getNumberOfBeds(){
		return $this->numberOfBeds;
	}

	public  function  setNumberOfBeds($numberOfBeds){
		if($numberOfBeds<0){
			echo "Number of beds cannot be negative value";
			return;
		}

		$this->numberOfBeds=$numberOfBeds;
	}

	public  function  getExtras(){
		return $this->extras;
	}

	public  function  setExtras($extras){
		$this->extras=$extras;
	}

	public  function  getReservations(){
		return $this->reservations;
	}

	public function  setReservations($reservations){
		$this->reservations=$reservations;
	}

	public function addReservation($reservation){
		$newReservations = $this->getReservations();

		foreach($newReservations as $key=>$value){
			if($value==$reservation){
				throw new EReservationException("Reservation already exists");
			}
		}

		$newReservations[]=$reservation;

		$this->setReservations($newReservations);
	}

	public function removeReservation($reservation){
		$newReservations = $this->getReservations();
		foreach($newReservations as $key=>$value){
			if($value==$reservation){
				unset($newReservations[$key]);
			}
		}

		$this->setReservations($newReservations);
	}

	public  function  __toString(){
		$result = "Number of the room: ".$this->getRoomNumber()."<br/>"
			. "Price: ".$this->getPrice()."<br/>"
			. "Number of beds: ".$this->getNumberOfBeds()."<br/>"
			. "Room type: ".$this->getRoomType()."<br/>";

		if(count($this->getExtras())>0) {
			$result .= "Extras: <br/>";

			foreach ($this->getExtras() as $extra) {
				$result .= "<em>" . $extra . "</em>"
					. "<br/>";
			}
		}

		if(count($this->getReservations())>0) {
			$result .= "Reservations: <br/>";

			foreach ($this->getReservations() as $reservation) {
				$result .= "<em>" . $reservation . "</em>"
					. "<br/>";
			}
		}

		return $result;
	}
}
?>