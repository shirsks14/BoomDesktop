ang = linspace(0,2*pi,50);
xd = cos(ang);
yd = sin(ang);
plotCircle = @(x,d) line(d*xd+x,d*yd);

%%
cla
% particle velocity
pv = 2;
% delta t
dt = 2;
% wave velocity
wv = 1.5;

maxi = 40;
for i = 1:maxi
    cla
    grid on
    for j = 0:i
        x = i*dt*pv-(j*dt*pv);
        y = 0;
        d = (j+1)*dt*wv;
        plotCircle(x,d)
    end
    line(i*dt*pv,0,'Color','red','Marker','.')
    axis(100*[-1 1 -1 1])
    axis equal
    pause(0.05)
    drawnow
end