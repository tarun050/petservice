Ç 
wC:\Users\Gokul\source\repos\Petzey.ViewAllPets.Service\Petzey.ViewAllPet.Services\Mapping\Implementations\PetMapping.cs
	namespace

 	
Petzey


 
.

 

ViewAllPet

 
.

 
Services

 $
.

$ %
Mapping

% ,
.

, -
Implementations

- <
{ 
public 

class 

PetMapping 
: 
IPetMapping )
{ 
public 
PetOwner )
ChangePetProfileDtoToPetOwner 5
(5 6
	AddPetDTO6 ?
	addPetDTO@ I
)I J
{ 	
PetOwner 
petOwner 
= 
new  #
PetOwner$ ,
(, -
)- .
{ 
PetOwnerName 
= 
	addPetDTO (
.( )
PetOwnerName) 5
,5 6
petProfiles 
= 
new !
List" &
<& '

PetProfile' 1
>1 2
(2 3
)3 4
{ 
new 

PetProfile "
(" #
)# $
{ 
PetName 
=  !
	addPetDTO" +
.+ ,
PetName, 3
,3 4
Age 
= 
	addPetDTO &
.& '
Age' *
,* +
Species 
=  !
	addPetDTO" +
.+ ,
Species, 3
,3 4
	Allergies !
=" #
	addPetDTO$ -
.- .
	Allergies. 7
,7 8

BloodGroup "
=# $
	addPetDTO% .
.. /

BloodGroup/ 9
,9 :
DateOfBirth #
=# $
	addPetDTO% .
.. /
DateOfBirth/ :
,: ;
Gender 
=  
	addPetDTO! *
.* +
Gender+ 1
,1 2
URL 
= 
	addPetDTO '
.' (
URL( +
} 
}   
}!! 
;!! 
return"" 
petOwner"" 
;"" 
}## 	
public%% 
ICollection%% 
<%% 
PetProfileCardDTO%% ,
>%%, -,
 ChangePetProfileToPetProfileCard%%. N
(%%N O
ICollection%%O Z
<%%Z [
PetOwner%%[ c
>%%c d
pets%%e i
)%%i j
{&& 	
ICollection'' 
<'' 
PetProfileCardDTO'' )
>'') *
petProfileCards''+ :
=''; <
new''= @
List''A E
<''E F
PetProfileCardDTO''F W
>''W X
(''X Y
)''Y Z
;''Z [
foreach(( 
((( 
var(( 
pet((  
in((! #
pets(($ (
)((( )
{)) 
foreach** 
(** 
var**  
p**! "
in**# %
pet**& )
.**) *
petProfiles*** 5
)**5 6
{++ 
PetProfileCardDTO,, )
petProfileCard,,* 8
=,,9 :
new,,; >
PetProfileCardDTO,,? P
(,,P Q
),,Q R
;,,R S
petProfileCard-- &
.--& '
Name--' +
=--, -
p--. /
.--/ 0
PetName--0 7
;--7 8
petProfileCard.. &
...& '
Gender..' -
=... /
p..0 1
...1 2
Gender..2 8
;..8 9
petProfileCard// &
.//& '
Age//' *
=//+ ,
p//- .
.//. /
Age/// 2
;//2 3
petProfileCard00 &
.00& '
PetOwnerName00' 3
=004 5
pet006 9
.009 :
PetOwnerName00: F
;00F G
petProfileCard11 &
.11& '
URL11' *
=11+ ,
p11- .
.11. /
URL11/ 2
;112 3
petProfileCards22 '
.22' (
Add22( +
(22+ ,
petProfileCard22, :
)22: ;
;22; <
}33 
}44 
return55 
petProfileCards55 &
;55& '
}66 	
}77 
}88 „
sC:\Users\Gokul\source\repos\Petzey.ViewAllPets.Service\Petzey.ViewAllPet.Services\Mapping\Interfaces\IPetMapping.cs
	namespace		 	
Petzey		
 
.		 

ViewAllPet		 
.		 
Services		 $
.		$ %
Mapping		% ,
.		, -

Interfaces		- 7
{

 
public 

	interface 
IPetMapping  
{ 
public 
ICollection 
< 
PetProfileCardDTO ,
>, -,
 ChangePetProfileToPetProfileCard. N
(N O
ICollectionO Z
<Z [
PetOwner[ c
>c d
pete h
)h i
;i j
public 
PetOwner )
ChangePetProfileDtoToPetOwner 5
(5 6
	AddPetDTO6 ?
	addPetDTO@ I
)I J
;J K
} 
}  
xC:\Users\Gokul\source\repos\Petzey.ViewAllPets.Service\Petzey.ViewAllPet.Services\Services\Implementations\PetService.cs
	namespace 	
Petzey
 
. 

ViewAllPet 
. 
Services $
.$ %
Services% -
.- .
Implementations. =
{ 
public 

class 

PetService 
: 
IPetService )
{ 
IPetRepository 
repo 
; 
IPetMapping 
mapping 
; 
public 

PetService 
( 
) 
{ 	
repo 
= 
new 
PetRepository $
($ %
)% &
;& '
mapping 
= 
new 

PetMapping $
($ %
)% &
;& '
} 	
public 
bool 
AddPet 
( 
	AddPetDTO $
	addPetDTO% .
). /
{ 	
PetOwner 
petOwner 
= 
mapping  '
.' ()
ChangePetProfileDtoToPetOwner( E
(E F
	addPetDTOF O
)O P
;P Q
return 
repo 
. 
Add 
( 
petOwner $
)$ %
;% &
} 	
public!! 
ICollection!! 
<!! 
PetProfileCardDTO!! ,
>!!, -
GetAllPetProfiles!!. ?
(!!? @
)!!@ A
{"" 	
ICollection## 
<## 
PetOwner##  
>##  !
pet##" %
=##& '
repo##( ,
.##, -
GetAllPetProfile##- =
(##= >
)##> ?
;##? @
ICollection$$ 
<$$ 
PetProfileCardDTO$$ )
>$$) *
petProfileCards$$+ :
=$$; <
mapping$$= D
.$$D E,
 ChangePetProfileToPetProfileCard$$E e
($$e f
pet$$f i
)$$i j
;$$j k
return%% 
petProfileCards%% "
;%%" #
}&& 	
}'' 
}(( þ
tC:\Users\Gokul\source\repos\Petzey.ViewAllPets.Service\Petzey.ViewAllPet.Services\Services\Interfaces\IPetService.cs
	namespace		 	
Petzey		
 
.		 

ViewAllPet		 
.		 
Services		 $
.		$ %
Services		% -
.		- .

Interfaces		. 8
{

 
public 

	interface 
IPetService  
{ 
public 
ICollection 
< 
PetProfileCardDTO ,
>, -
GetAllPetProfiles. ?
(? @
)@ A
;A B
public 
bool 
AddPet 
( 
	AddPetDTO $
	addPetDTO% .
). /
;/ 0
} 
} 