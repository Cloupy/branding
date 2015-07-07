@Code
    ViewData("Title") = "Servicios comercio electrónico para micropymes | Cloupy"
End Code

<main  class="main-home">
   
        <div class="container">


            <div id="particles-js" class="row">
                
            </div>


        </div>
   
</main>

@section ScriptsFooter

    <script type='text/javascript'>
        particlesJS('particles-js', {
            particles: {
                color: '#efefef',
                shape: 'circle', // "circle", "edge" or "triangle"
                opacity: 1,
                size: 1.0,
                size_random: true,
                nb: 350,
                line_linked: {
                    enable_auto: true,
                    distance: 100,
                    color: '#fff',
                    opacity: 0.6,
                    width: 1,
                    condensed_mode: {
                        enable: false,
                        rotateX: 300,
                        rotateY: 300
                    }
                },
                anim: {
                    enable: true,
                    speed: 2
                }
            },
            interactivity: {
                enable: true,
                mouse: {
                    distance: 300
                },
                detect_on: 'window', // "canvas" or "window"
                mode: 'grab',
                line_linked: {
                    opacity: .5
                },
                events: {
                    onclick: {
                        enable: true,
                        mode: 'push', // "push" or "remove"
                        nb: 4
                    }
                }
            },
            /* Retina Display Support */
            retina_detect: true
        });


    </script>


End Section