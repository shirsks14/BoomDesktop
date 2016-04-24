function Y = Circle(radius,center,pathangle)
Y = zeros(length(radius), length(radius));
% th = linspace( pathangle + pi/4, pathangle -pi/4, 100);
for i = 1:length(radius)
    for j = 1:length(radius)
%         R = radius;  %or whatever radius you want
        temp= radius(i);
%         x = radius(1,i)*cos(th) + center(1);
%         y = radius(1,j)*sin(th) + center(2);
        Y(i,j) = sqrt(radius(i)^2+radius(j)^2);
    end
end
% R = radius;  %or whatever radius you want
% x = R*cos(th) + center(1);
% y = R*sin(th) + center(2);
% plot(x,y,'color',color); axis equal;

end