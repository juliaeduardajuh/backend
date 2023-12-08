const video = document.querySelector('.video');
const botaoCamera = document.querySelector('.botaoCamera');
const canvas = document.querySelector('.canvas');
const fotosContainer = document.querySelector('.fotos');

const fotos = [];

navigator.mediaDevices.getUserMedia({video : true})
         .then(stream => {
            video.srcObject = stream;
            video.play();
         })
         .catch(error =>{

         })

         botaoCamera.addEventListener('click', () => {
            canvas.getContext('2d').drawImage(video,0,0,
                 canvas.width, canvas.height);

                 let urlImage = canvas.toDataURL('image/jpeg');

                 const foto = document.createElement('img');
                 foto.src = urlImage;
                 foto.className = 'foto';
                 fotosContainer.innerHTML='';
                 fotosContainer.appendChild(foto);


                 fotos.push(urlImage);

                 foto.addEventListener('click', () => {
                    downloandImagem(urlImage);
                 })
         })

         function downloandImagem(dataUrl){
            const a = document.createElement('a');
            a.href = dataUrl;
            a.download = 'foto.jpg';
            a.style.display = 'none';
            document.body.appendChild(a);
            a.click();
            document.body.removeChild(a);
         }